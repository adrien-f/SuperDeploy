using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperDeploy.ViewModels
{
    public class NewApplicationViewModel
    {
        public List<Supervisor.Process> Processes { get; set; }
        [Required]
        public string SelectedProcess { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; } 
    }
}
