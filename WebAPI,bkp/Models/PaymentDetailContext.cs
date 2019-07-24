using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class PaymentDetailContext : DbContext
    {


        public DbSet<PaymentDetail> PaymentDetails { get; set; }

    }
}