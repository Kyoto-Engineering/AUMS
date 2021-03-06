﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppUserManagementSystem.Ui
{
   public class Users
    {
        private string employeeId;
        private int userId;
        private string userName;
        private string fullName;
        private string nickName;
        private string fatherName;
        private string motherName;


        private int emailBankId;
        private int countryId;
        // private Nullable<int> designationId;
        private int? designationId;
        // private int designationId;
        private int departmentId;
        private string password;
        private Nullable<DateTime> dateOfBirth;

        private int nationalityId;
        public string birthCertificateNumber;
        public string passportNumber;

        public int genderId;
        public byte userImage;
        public int maritalStatusId;
        public DateTime registrationDate;
        public DateTime exitDate;
        public int caaaiid;
        public string CountryName { set; get; }
        public string EmailAdd { set; get; }
        public string DesignationName { set; get; }
        public string Genders { set; get; }
        public string MaritalStatusss { set; get; }
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

      

        public int UserId
        {
            set { userId = value; }
            get { return userId; }
        }

        public string UserName
        {
            set { userName = value; }
            get { return userName; }
        }

        public int Caaatid
        {
            set { caaaiid = value; }
            get { return caaaiid; }
        }

        public string FullName
        {
            set { fullName = value; }
            get { return fullName; }
        }
        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }

        public string MotherName
        {
            get { return motherName; }
            set { motherName = value; }
        }

        public int EmailHostId { set; get; }
        public int EmailBankId
        {
            set { emailBankId = value; }
            get { return emailBankId; }
        }

        public int CountryId
        {
            set { countryId = value; }
            get { return countryId; }
        }

        public int DepartmentId
        {
            set { departmentId = value; }
            get { return departmentId; }
        }
        public int? DesignationId
        {
            set { designationId = value; }
            get { return designationId; }
        }
        //public  Nullable<int> DesignationId
        //{
        //    set { designationId = value; }
        //    get { return designationId; }
        //}
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        // DateTime? MyDateTime { get; set; }
        public Nullable<DateTime> DateOfBirth
        {
            set { dateOfBirth = value; }
            get { return dateOfBirth; }
        }

        public string NationalId { set; get; }

        public int NationalityId
        {
            set { nationalityId = value; }
            get { return nationalityId; }
        }

        public string BirthCertificateNo
        {
            get { return birthCertificateNumber; }
            set { birthCertificateNumber = value; }
        }

        public string PassportNo
        {
            get { return passportNumber; }
            set { passportNumber = value; }
        }


        public int GenderId
        {
            get { return genderId; }
            set { genderId = value; }
        }

        public byte UserImage
        {
            get { return userImage; }
            set { userImage = value; }
        }

        public int MaritalStatusId
        {
            get { return maritalStatusId; }
            set { maritalStatusId = value; }
        }

        public DateTime RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }

        public DateTime ExitDate
        {
            get { return exitDate; }
            set { exitDate = value; }
        }
        public int EmpStatus { set; get; }
    }
}
