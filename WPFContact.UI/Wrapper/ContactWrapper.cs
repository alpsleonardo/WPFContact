using System;
using WPFContact.Model;

namespace WPFContact.UI.Wrapper
{
    public class ContactWrapper
    {
        public ContactWrapper(Contact model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }
            Model = model;
        }

        public Contact Model { get; set; }
        public string FirstName
        {
            get
            {
                return Model.FirstName;
            }
            set
            {
                Model.FirstName = value;
            }
        }
    }
}
