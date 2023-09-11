namespace Template {
    abstract class BaseReport {
        protected string title;
        protected string description;
        public BaseReport(string title, string description) {
            this.title = title; this.description = description;
        }

        public abstract string getReport();
    }

    class JsonReport : BaseReport {
        public JsonReport(string title, string description) : base(title, description) {
            
        }

        public override string getReport() {
            return $"{{ {title} : {description} }}";
        }
    }

    class HtmlReport : BaseReport {
        public HtmlReport(string title, string description) : base(title, description) {
        }

        public override string getReport() {
            return "<HTML>" +
                    "<HEAD>" +
                    "</HEAD>" +
                    "<BODY>" +
                      $"<H1> {title} </H1>" +
                      $"<P> {description} </P>" +
                    "</BODY>" +
                   "</HTML>";
        }
    }

}
