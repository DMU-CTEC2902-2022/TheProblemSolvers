using Information_and_technology_college.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Information_and_technology_college.Controllers
{
    public class SoftwareengineeringController : Controller
    {
        // GET: SoftwareEngineering
        public ViewResult Modules()
        {
            //SoftwareEngineering Modules0
            Software_engineering SEModel = new Software_engineering();
            SEModel.ModuleCode = "SE3906";
            SEModel.ModuleTitle = "Interaction Design.";
            SEModel.ModuleDescription = "Interaction design, often abbreviated as IxD, is the practice of designing interactive digital products, environments, systems, and services. Beyond the digital aspect, interaction design is also useful when creating physical products, exploring how a user might interact with it.";
            SEModel.ModuleContents = "Foudations and Importance of Design.";
            SEModel.StaffMembers = "DR. Albert, chris";

            //SoftwareEngineering Modules1
            Software_engineering SEModel1  = new Software_engineering();
            SEModel.ModuleCode1 = "SE3410";
            SEModel.ModuleTitle1 = "Web Application Penetration Testing.";
            SEModel.ModuleDescription1 = "A web application penetration test is a type of ethical hacking engagement designed to assess the architecture, design and configuration of web applications. Assessments are conducted to identify cyber security risks that could lead to unauthorised access and/or data exposure.";
            SEModel.ModuleContents1 = "web testing";
            SEModel.StaffMembers1 = "Dr.ben, Dr.roy";

            //SoftwareEngineering Modules2
            Software_engineering SEModel2  = new Software_engineering();
            SEModel.ModuleCode2 = "SE3406";
            SEModel.ModuleTitle2 = "Fuzzy Logic & Knowledge Based Systems.";
            SEModel.ModuleDescription2 = "In fuzzy logic systems, the fuzzy knowledge base represents the facts of the rules and linguistic variables based on the fuzzy set theory so that the knowledge base sytems will allow approximate reasoning.";
            SEModel.ModuleContents2 = "Foundations of fuzzy logic.";
            SEModel.StaffMembers2 = "Dr aljamin sterling";

            //SoftwareEngineering Modules3
            Software_engineering SEModel3  = new Software_engineering();
            SEModel.ModuleCode3 = "SE3613";
            SEModel.ModuleTitle3 = "Data Mining.";
            SEModel.ModuleDescription3 = "Data mining is the process of finding anomalies, patterns and correlations within large data sets to predict outcomes. Using a broad range of techniques, you can use this information to increase revenues, cut costs, improve customer relationships, reduce risks and more.";
            SEModel.ModuleContents3 = "Data warehouse";
            SEModel.StaffMembers3 = "Moath al doori";

            //SoftwareEngineering Modules4
            Software_engineering SEModel4 = new Software_engineering();
            SEModel.ModuleCode4 = "SE3614";
            SEModel.ModuleTitle4 = "Big Data & Business Models";
            SEModel.ModuleDescription4 = "The big data business models can be classified into four types: Data Users: Businesses which use data to form strategies and build better products.";
            SEModel.ModuleContents4 = "Big data modelling";
            SEModel.StaffMembers4 = "DR. peter .";

            //SoftwareEngineering Modules5
            Software_engineering SEModel5 = new Software_engineering();
            SEModel.ModuleCode5 = "IMAT3611";
            SEModel.ModuleTitle5 = "Computer Ethics and Privacy.";
            SEModel.ModuleDescription5 = "Privacy in computer ethics refers to the ethical dilemmas that computer users face in some situations that may lead to the violation of another person's privacy through the use of computers.";
            SEModel.ModuleContents5 = "Cyber law";
            SEModel.StaffMembers5 = "Ryan hemsworth";

            //SoftwareEngineering Modules6
            Software_engineering SEModel6  = new Software_engineering();
            SEModel.ModuleCode6 = "SE3451";
            SEModel.ModuleTitle6 = "Development Project.";
            SEModel.ModuleDescription6 = "Development Project means any construction, development or infrastructure project, including without limitation greenfield projects and brownfield projects, in which the Company or any of its Subsidiaries participates or holds, directly or indirectly, an interest, or the bidding on any such project.";
            SEModel.ModuleContents6 = "Team development project";
            SEModel.StaffMembers6 = "Dr kevin, Dr. harden";
            return View(SEModel);
        }
    }
}