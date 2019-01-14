using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO
{
    public class CustomerTypeDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }

        public CustomerTypeDto(string id, string name, string message)
        {
            Id = id;
            Name = name;
            Message = message;
        }

        public CustomerTypeDto()
        {

        }

        public CustomerTypeDto(string message)
        {
            Message = message;
        }
    }
}
