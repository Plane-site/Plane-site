using Microsoft.EntityFrameworkCore;
using PlaneTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTest1.Data
{
    public class FlightsTicketsDbContext : DbContext//Прави се клас наследник на DbContext който ще помогне за създаването на базата данни в MS Sql
    {
        public DbSet<Flights> Flights { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public FlightsTicketsDbContext(DbContextOptions<FlightsTicketsDbContext> options) : base(options)
        {

        }
        // след като връзките във appsettings.json са направени и използвани в Startup.cs можем да направим миграциите и да актоализираме базите данни.
        //чрез Package Manager Console  ще направим миграцията и актуализирането на базата данни задавайки използването на FlightsTicketsDbContext    като контекст клас.
        //след което  Microsoft.EntityFrameworkCore.Tools   ще генерира код за контолерите и изгледите използвайки моделния клас и контекст класът.

    }
}
