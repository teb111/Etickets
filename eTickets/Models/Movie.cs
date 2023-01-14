﻿ using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eTickets.Data;

namespace eTickets.Models
{
	public class Movie
	{
		[Key]

		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public double Price { get; set; }

		public string ImageURL { get; set; }

		public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //relationship
		// many-to-many relationship
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        // one-to-many relationship
        public int CinemaId { get; set; }
		[ForeignKey("CinemaId")]

		public Cinema Cinema { get; set; }

        //Producer
        // one-to-many relationship
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]

        public Producer Producer { get; set; }
    }
}

