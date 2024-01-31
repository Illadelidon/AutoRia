using AutoRia.Core.Entities.CarsInfo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Infrastructure.Initializers
{
    internal static class CarInfoInitializer
    {
        public static void SeedCarInfo(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accident>().HasData(new Accident[]
            {
                new Accident(){Id=1,YesOrNot="Yes"},
                new Accident(){Id=2,YesOrNot="No"},
            });
            modelBuilder.Entity<BodyType>().HasData(new BodyType[]
            {
               new BodyType(){Id=1, Name="Седан"},
               new BodyType(){Id=2, Name="Універсал"},
               new BodyType(){Id=3, Name="Купе"},
               new BodyType(){Id=4, Name="Кросовер"},
               new BodyType(){Id=5, Name="Хетчбек"},
               new BodyType(){Id=6, Name="Мікроавтобуси"},
            });
            modelBuilder.Entity<Brand>().HasData(new Brand[]
            {
                new Brand(){Id=1, Name="BMW"},
                new Brand(){Id=2, Name="Audi"},
                new Brand(){Id=3, Name="Mercedes-Benz"},
                new Brand(){Id=4, Name="Subaru"},
                new Brand(){Id=5, Name="Toyota"},
                new Brand(){Id=6, Name="Chevrolet"},
                new Brand(){Id=7, Name="Ford"},
                new Brand(){Id=8, Name="Honda"},
                new Brand(){Id=9, Name="Kia"},
                new Brand(){Id=10, Name="Mazda"},
                new Brand(){Id=11, Name="Nissan"},
                new Brand(){Id=12, Name="Skoda"},
                new Brand(){Id=13, Name="Volkswagen"},
                new Brand(){Id=14, Name="Volvo"},
                new Brand(){Id=15, Name="Lexus"},
            });
            modelBuilder.Entity<Color>().HasData(new Color[]
            {
                new Color(){Id=1, Name="Black"},
                new Color(){Id=2, Name="White"},
                new Color(){Id=3, Name="Red"},
                new Color(){Id=4, Name="Green"},
                new Color(){Id=5, Name="Blue"},
                new Color(){Id=6, Name="Gray"},
                new Color(){Id=7, Name="Yellow"},
                new Color(){Id=8, Name="Pink"},
                new Color(){Id=9, Name="Purple"},
            } );
            modelBuilder.Entity<Currency>().HasData(new Currency[]
            {
               new Currency(){Id=1, Name="USD"},
               new Currency(){Id=2, Name="EUR"},
               new Currency(){Id=3, Name="UAN"},
            });
            modelBuilder.Entity<GraduationYear>().HasData(new GraduationYear[]
            {
              new GraduationYear(){Id=1,date= new DateTime(2000,1,1) },
              new GraduationYear(){Id=2,date= new DateTime(2001,1,1) },
              new GraduationYear(){Id=3,date= new DateTime(2002,1,1) },
              new GraduationYear(){Id=4,date= new DateTime(2003,1,1) },
              new GraduationYear(){Id=5,date= new DateTime(2004,1,1) },
              new GraduationYear(){Id=6,date= new DateTime(2005,1,1) },
              new GraduationYear(){Id=7,date= new DateTime(2006,1,1) },
              new GraduationYear(){Id=8,date= new DateTime(2007,1,1) },
              new GraduationYear(){Id=9,date= new DateTime(2008,1,1) },
              new GraduationYear(){Id=10,date= new DateTime(2009,1,1) },
              new GraduationYear(){Id=11,date= new DateTime(2010,1,1) },
              new GraduationYear(){Id=12,date= new DateTime(2011,1,1) },
              new GraduationYear(){Id=13,date= new DateTime(2012,1,1) },
              new GraduationYear(){Id=14,date= new DateTime(2013,1,1) },
              new GraduationYear(){Id=15,date= new DateTime(2014,1,1) },
              new GraduationYear(){Id=16,date= new DateTime(2015,1,1) },
              new GraduationYear(){Id=17,date= new DateTime(2016,1,1) },
              new GraduationYear(){Id=18,date= new DateTime(2017,1,1) },
              new GraduationYear(){Id=19,date= new DateTime(2018,1,1) },
              new GraduationYear(){Id=20,date= new DateTime(2019,1,1) },
              new GraduationYear(){Id=21,date= new DateTime(2020,1,1) },
              new GraduationYear(){Id=22,date= new DateTime(2021,1,1) },
              new GraduationYear(){Id=23,date= new DateTime(2022,1,1) },
              new GraduationYear(){Id=24,date= new DateTime(2023,1,1) },
              new GraduationYear(){Id=25,date= new DateTime(2024,1,1) },
            });
            modelBuilder.Entity<Mileage>().HasData(new Mileage[]
            {
              new Mileage() { Id = 1, mileage= "5000-15000"},
              new Mileage() { Id = 2, mileage= "15000-50000"},
              new Mileage() { Id = 3, mileage= "50000-150000"},
              new Mileage() { Id = 4, mileage= "150000-300000"},
              new Mileage() { Id = 5, mileage= "300000-500000"},
            });
            modelBuilder.Entity<Model>().HasData(new Model[]
           {
              new Model() { Id = 1, Name="3 series"},
              new Model() { Id = 2, Name="4 series"},
              new Model() { Id = 3, Name="5 series"},
              new Model() { Id = 4, Name="7 series"},
              new Model() { Id = 5, Name="M3"},
              new Model() { Id = 6, Name="M4"},
              new Model() { Id = 7, Name="M5"},
              new Model() { Id = 8, Name="M8"},
              new Model() { Id = 9, Name="X1"},
              new Model() { Id = 10, Name="X2"},
              new Model() { Id = 11, Name="X3"},
              new Model() { Id = 12, Name="X4"},
              new Model() { Id = 13, Name="X5"},
              new Model() { Id = 14, Name="X6"},
              new Model() { Id = 15, Name="X7"},
              new Model() { Id = 16, Name="X3M"},
              new Model() { Id = 17, Name="X4M"},
              new Model() { Id = 18, Name="X5M"},
              new Model() { Id = 19, Name="X6M"},
              new Model() { Id = 20, Name="C-Class"},
              new Model() { Id = 21, Name="CLA-Class"},
              new Model() { Id = 22, Name="CLS-Class"},
              new Model() { Id = 23, Name="E-Class"},
              new Model() { Id = 24, Name="GLA-Class"},
              new Model() { Id = 25, Name="GLS-Class"},
              new Model() { Id = 26, Name="Maybach"},
              new Model() { Id = 27, Name="A1"},
              new Model() { Id = 28, Name="A2"},
              new Model() { Id = 29, Name="A3"},
              new Model() { Id = 30, Name="A4"},
              new Model() { Id = 31, Name="A5"},
              new Model() { Id = 32, Name="A6"},
              new Model() { Id = 33, Name="A7"},
              new Model() { Id = 34, Name="A8"},
              new Model() { Id = 35, Name="Q2"},
              new Model() { Id = 36, Name="Q3"},
              new Model() { Id = 37, Name="Q4"},
              new Model() { Id = 38, Name="Q5"},
              new Model() { Id = 39, Name="Q7"},
              new Model() { Id = 40, Name="Q8"},
              new Model() { Id = 41, Name="RS2"},
              new Model() { Id = 42, Name="RS3"},
              new Model() { Id = 43, Name="RS4"},
              new Model() { Id = 44, Name="RS5"},
              new Model() { Id = 45, Name="RS6"},
              new Model() { Id = 46, Name="RS7"},
              new Model() { Id = 47, Name="RS8"},
           });
            modelBuilder.Entity<ProducingCountry>().HasData(new ProducingCountry[]
            {
              new ProducingCountry() { Id = 1, Name="Germany"},
              new ProducingCountry() { Id = 2, Name="Poland"},
              new ProducingCountry() { Id = 3, Name="Italy"},
              new ProducingCountry() { Id = 4, Name="UK"},
              new ProducingCountry() { Id = 5, Name="USA"},
              new ProducingCountry() { Id = 6, Name="Franch"},
            });
            modelBuilder.Entity<Sity>().HasData(new Sity[]
            {
             new Sity() { Id = 1, Name="Kyiv"},
             new Sity() { Id = 2, Name="Odessa"},
             new Sity() { Id = 3, Name="Lviv"},
             new Sity() { Id = 4, Name="Rivne"},
             new Sity() { Id = 5, Name="Poltava"},
             new Sity() { Id = 6, Name="Chernigiv"},
             new Sity() { Id = 7, Name="Ternopil"},
            });
            modelBuilder.Entity<TypeCar>().HasData(new TypeCar[]
           {
               new TypeCar(){Id=1, Name="Легкові"},
               new TypeCar(){Id=2, Name="Мото"},
               new TypeCar(){Id=3, Name="Вантажівки"},
               new TypeCar(){Id=4, Name="Спецтехніка"},
               new TypeCar(){Id=5, Name="Автобуси"},
               new TypeCar(){Id=6, Name="Водний транспорт"},
               new TypeCar(){Id=7, Name="Автобудинки"},
           });

        }
    }
}
