using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactApp.Client.Models
{
    public class Contact
    {
        private string _Name;

        [Required]
        [DataType(DataType.Text)]
        public int ContactId { get; set; }

        [Required]
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value != null)
                {
                    _Name = value;
                }

            }


        }

        public Contact()
        {

            strings = new List<SelectListItem>()
            {
                new SelectListItem(){Text="name to whow",Value="content to save",Selected=true}
            };
            
        }

        private bool CheckNull(object o)
        {
            return o == null;
        }
    }
}