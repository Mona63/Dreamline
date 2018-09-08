using System;
using System.ComponentModel.DataAnnotations;
using Dreamlines.Dtos;

namespace Dreamlines.Data {
    
    public class SalesUnitQuery: IPaginatedQuery<SalesUnitSummary> {
        public int Skip { get; set; } = 0;
        public int Limit { get; set; } = 100;
        [Required]
        public DateTime? FromDate { get; set; }
        [Required]
        public DateTime? ToDate { get; set; }
    }
    
}