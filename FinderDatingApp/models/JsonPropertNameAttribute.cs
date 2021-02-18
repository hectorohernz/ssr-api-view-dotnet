using System;

namespace FinderDatingApp.models
{
    internal class JsonPropertNameAttribute : Attribute
    {
        private string v;

        public JsonPropertNameAttribute(string v)
        {
            this.v = v;
        }
    }
}