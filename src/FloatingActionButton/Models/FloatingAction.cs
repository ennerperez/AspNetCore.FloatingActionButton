using System.Collections.Generic;

namespace Microsoft.AspNetCore.Mvc.Models
{
    public class FloatingAction
    {
        public List<FloatingAction> Actions { get; set; }

        public string Title { get; set; }

        public string Class { get; set; } = "btn-default";

        public string Url { get; set; }
        public string Target { get; set; }
        public string Icon { get; set; }

        public FloatingAction()
        {
            Actions = new List<FloatingAction>();
        }

    }
}
