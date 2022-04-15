using Information_and_technology_college.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Information_and_technology_college.Controllers
{
    public class ComputerscienceController : Controller
    {
        // GET: Computerscience
        public ViewResult Modules()
        {
            //ComputerScience Modules0
            Computerscience CSModel = new Computerscience();
            CSModel.ModuleCode = "COS1903 ";
            CSModel.ModuleTitle = "Scala Programming.";
            CSModel.ModuleDescription = "Scala is a strong statically typed general-purpose programming language which supports both object-oriented programming and functional programming. Designed to be concise, many of Scala's design decisions are aimed to address criticisms of Java.";
            CSModel.ModuleContents = "Scala Coding ";
            CSModel.StaffMembers = "John smith";

            //ComputerScience Modules1
            Computerscience CSModel1 = new Computerscience();
            CSModel.ModuleCode1 = "COS1920";
            CSModel.ModuleTitle1 = "Database Management";
            CSModel.ModuleDescription1 = "Database management refers to the actions a business takes to manipulate and control data to meet necessary conditions throughout the entire data lifecycle.";
            CSModel.ModuleContents1 = "Database design, and Database development.";
            CSModel.StaffMembers1 = "Paul craig";

            //ComputerScience Modules2
            Computerscience CSModel2 = new Computerscience();
            CSModel.ModuleCode2 = "COS2905";
            CSModel.ModuleTitle2 = "Object Oriented Programming.";
            CSModel.ModuleDescription2 = "Object-oriented programming (OOP) is a computer programming model that organizes software design around data, or objects, rather than functions and logic. An object can be defined as a data field that has unique attributes and behavior.";
            CSModel.ModuleContents2 = "c sharp";
            CSModel.StaffMembers2 = "Henruy cejudo";

            //ComputerScience Modules3
            Computerscience CSModel3 = new Computerscience();
            CSModel.ModuleCode3 = "COS3911";
            CSModel.ModuleTitle3 = "Mobile Application.";
            CSModel.ModuleDescription3 = "Mobile app development is the act or process by which a mobile app is developed for mobile devices, such as personal digital assistants, enterprise digital assistants or mobile phones. These software applications are designed to run on mobile devices, such as a smartphone or tablet computer";
            CSModel.ModuleContents3 = "Mobile robototics.";
            CSModel.StaffMembers3 = "Peter yan";

            //ComputerScience Modules4
            Computerscience CSModel4 = new Computerscience();
            CSModel.ModuleCode4 = "IMAT3611";
            CSModel.ModuleTitle4 = "Computer Ethics and Privacy.";
            CSModel.ModuleDescription4 = "Ethics is a set of moral principles that govern the behavior of an individual or group of people. Computer ethics is the application of moral principles to the use of computers and the Internet.";
            CSModel.ModuleContents4 = "cyber law and crime";
            CSModel.StaffMembers4 = "dustin poirier";

            //ComputerScience Modules5
            Computerscience CSModel5 = new Computerscience();
            CSModel.ModuleCode5 = "COS3451";
            CSModel.ModuleTitle5 = "Development Project.";
            CSModel.ModuleDescription5 = "Development Project means any construction, development or infrastructure project, including without limitation greenfield projects and brownfield projects, in which the Company or any of its Subsidiaries participates or holds, directly or indirectly, an interest, or the bidding on any such project.";
            CSModel.ModuleContents5 = "Project Development.";
            CSModel.StaffMembers5 = "Justin gathje";

            //ComputerScience Modules6
            Computerscience CSModel6 = new Computerscience();
            CSModel.ModuleCode6 = "COS2910";
            CSModel.ModuleTitle6 = "Database Management.";
            CSModel.ModuleDescription6 = "Database management refers to the actions a business takes to manipulate and control data to meet necessary conditions throughout the entire data lifecycle.";
            CSModel.ModuleContents6 = "Database management and reporting.";
            CSModel.StaffMembers6 = "Francis ngannou";
            return View(CSModel);
        }


    }
}