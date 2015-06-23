
using System.Collections.Generic;
using System.Text;
namespace GraphVizWrapper
{
    public abstract class Element
    {

        protected Dictionary<string,string> Styles;

        protected Element()
        {
            this.Styles = new Dictionary<string, string>();
        }


        public void AddStyle(string property, string value)
        {
            this.Styles.Add(property, value);
        }

        public string GetStyles()
        {
            var output = new StringBuilder();


            if (this.Styles.Count == 0)
            {
                return "";
            }
            else
            {
                output.Append("[");
                foreach (var row in Styles)
                {

                    output.Append(row.Key);
                    output.Append("=");
                    output.Append("\"");
                    output.Append(row.Value);
                    output.Append("\"");
                    output.Append(" ");

                }
                output.Append("]");
            }


            return output.ToString();
        }


    }
}
