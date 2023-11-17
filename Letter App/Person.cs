using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_App
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PassportNo { get; set; }
        public string PassportValidUntil { get; set; }
        public string BornAt { get; set; }
        public string Citizenship { get; set; }
        public string ResidentPermitNo { get; set; }
        public string RPValidUntil { get; set; }
        public string CompanyName {  get; set; }
        public string ONRC { get; set; }
        public string CUI { get; set; }
        public string FirmAddress { get; set; }
        public string RepresentsByName { get; set; }
        public string RepresentsBySurname { get; set; }
        public string Passport_IDNumber { get; set; }
        public string PassportIDValidUntil { get; set; }
        public string Profession {  get; set; }
        public string Salary { get; set; }
        public string PlacetoWork { get; set; }
        public string AccomodationAddress { get; set; }
        public string CORNumber { get; set; }
        public string Orgamigram { get; set; }
        public string OccupiedByRomanianCitizen { get; set; }
        public string OccupiedByImmigrationCitizen { get; set; }
        public string JobsVacancies {  get; set; }
        public string AJOFMDate {  get; set; }
        public string AJOFMCity { get; set; }
        public string NumberOfAJOFMPaper { get; set; }
        public string DateofAJOFMPaper { get; set;}


        public Person()
        {
            Name = string.Empty;
            SurName = string.Empty;
            PassportNo = string.Empty;
            PassportValidUntil = string.Empty;
            BornAt = string.Empty;
            Citizenship = string.Empty;
            ResidentPermitNo = string.Empty;
            RPValidUntil = string.Empty;
            CompanyName = string.Empty;
            ONRC = string.Empty;
            CUI = string.Empty;
            FirmAddress = string.Empty;
            RepresentsByName = string.Empty;
            RepresentsBySurname = string.Empty;
            Passport_IDNumber = string.Empty;
            PassportIDValidUntil = string.Empty;
            Profession = string.Empty;
            Salary = string.Empty;
            PlacetoWork = string.Empty;
            AccomodationAddress = string.Empty;
            CORNumber = string.Empty;
            Orgamigram = string.Empty;
            OccupiedByRomanianCitizen = string.Empty;
            OccupiedByImmigrationCitizen = string.Empty;
            JobsVacancies = string.Empty;
            AJOFMDate = string.Empty;
            AJOFMCity = string.Empty;
            NumberOfAJOFMPaper = string.Empty;
            DateofAJOFMPaper = string.Empty;
        }


        Person(string name, string surName, string passportNo, string validUntil, string bornAt, string citizenship, string residentPermitNo, string rPValidUntil, string companyName, string oNRC, string cUI, string firmAddress, string representsByName, string representsBySurname, string passport_IDNumber, string passportValidUntil, string profession, string salary, string placetoWork, string accomodationAddress, string cORNumber, string orgamigram, string occupiedByRomanianCitizen, string occupiedByImmigrationCitizen, string jobsVacancies, string aJOFMDate, string aJOFMCity, string numberOfAJOFMPaper, string dateofAJOFMPaper)
        {
            Name = name;
            SurName = surName;
            PassportNo = passportNo;
            PassportValidUntil = validUntil;
            BornAt = bornAt;
            Citizenship = citizenship;
            ResidentPermitNo = residentPermitNo;
            RPValidUntil = rPValidUntil;
            CompanyName = companyName;
            ONRC = oNRC;
            CUI = cUI;
            FirmAddress = firmAddress;
            RepresentsByName = representsByName;
            RepresentsBySurname = representsBySurname;
            Passport_IDNumber = passport_IDNumber;
            PassportIDValidUntil = passportValidUntil;
            Profession = profession;
            Salary = salary;
            PlacetoWork = placetoWork;
            AccomodationAddress = accomodationAddress;
            CORNumber = cORNumber;
            Orgamigram = orgamigram;
            OccupiedByRomanianCitizen = occupiedByRomanianCitizen;
            OccupiedByImmigrationCitizen = occupiedByImmigrationCitizen;
            JobsVacancies = jobsVacancies;
            AJOFMDate = aJOFMDate;
            AJOFMCity = aJOFMCity;
            NumberOfAJOFMPaper = numberOfAJOFMPaper;
            DateofAJOFMPaper = dateofAJOFMPaper;
        }


    }
}
