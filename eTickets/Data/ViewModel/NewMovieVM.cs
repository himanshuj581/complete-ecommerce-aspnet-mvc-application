using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Data.Base;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; } 

        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Category is required")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie Actor(s) is required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Movie Cinema is required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Movie Producer is required")]
        public int ProducerId { get; set; }
    }
}
