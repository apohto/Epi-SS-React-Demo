
function SearchResult({ title, description, linkUrl }) {
    return (
        <div className="search-result-container">
            <a className="result-title" href={linkUrl}>{title}</a>
            <div className="result-description">{description}</div>
        </div>
    );
}

class MainSearch extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            header: this.props.header,
            buttonText: this.props.buttonText,
            placeholder: this.props.placeholder,
            searchText: '',
            results: []
        };

        this.onFieldChange = this.onFieldChange.bind(this);
        this.getResults = this.getResults.bind(this);
    }

    onFieldChange(event) {
        this.setState({
            [event.target.name]: event.target.value
        });
    }

    getResults(event) {
        $.ajax({
            url: "/api/search/getResults",
            dataType: "json",
            type: "Get",
            data: {
                q: this.state.searchText
            },
            success: function(data) {
                this.setState({ results: data });
            },
            error: function(error, exception) {
                console.log(error + ": " + exception);
            }
        });
    }

    render() {
        return (
            <div className="search-container">
                <div className="search-section">
                    <h1 className="search-header">{this.state.header}</h1>
                    <input type="text" className="search-box" name="searchText" placeholder={this.state.placeholder} onChange={this.onFieldChange} />
                    <button className="search-button" onClick={this.getResults}>{this.state.buttonText}</ button>
                </div>
                <div className="results-section">
                    {
                        this.state.results.map(function (result) {
                            <SearchResult title={result.Title} description={result.Description} linkUrl={result.LinkUrl} key={result.Id} />
                        })
                    }
                </div>
            </div>
        );
    }
}
