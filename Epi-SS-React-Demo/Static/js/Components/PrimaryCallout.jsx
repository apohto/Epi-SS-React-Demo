
class PrimaryCallout extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            header: this.props.header,
            buttonText: this.props.buttonText,
            buttonLink: this.props.buttonLink
        };
    }

    render() {
        return (
            <div className="primary-callout-container">
                <h2 className="primary-callout-header">{this.state.header}</h2>
                <a href={this.state.buttonLink} className="primary-callout-link btn btn-primary">
                    {this.state.buttonText}
                </a>
            </div>
        );
    }
}
