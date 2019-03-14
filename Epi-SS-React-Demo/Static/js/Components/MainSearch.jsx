
function SearchResult({ title, description, linkUrl }) {
    return (
        <div className="search-result-container mt-4">
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

        var data = [
            {
                Title: "Google",
                Description: "The world's largest search engine",
                LinkUrl: "https://www.google.com"
            },
            {
                Title: "Github",
                Description: "The world's largest code repository",
                LinkUrl: "https://www.github.com"
            },
            {
                Title: "Youtube",
                Description: "The world's largest repository of cat videos",
                LinkUrl: "https://www.youtube.com"
            }];

        this.setState({ results: data });
    }

    render() {
        return (
            <div className="search-container">
                <div className="search-section">
                    <h1 className="search-header">{this.state.header}</h1>
                    <div className="col-sm-4 offset-sm-4 row">
                        <input type="text" className="search-box form-control col-sm-9" name="searchText" placeholder={this.state.placeholder} onChange={this.onFieldChange} />
                        <button className="search-button btn btn-primary col-sm-3" onClick={this.getResults}>{this.state.buttonText}</ button>
                    </div>
                    
                </div>
                <div className="results-section">
                    {
                        this.state.results.map(result => (
                            <SearchResult title={result.Title} description={result.Description} linkUrl={result.LinkUrl} key={result.Id} />
                        ))
                    }
                </div>
            </div>
        );
    }
}
