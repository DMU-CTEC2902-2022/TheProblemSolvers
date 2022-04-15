using Information_and_technology_college.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Information_and_technology_college.Controllers
{
    public class CybersecurityController : Controller
    {
        // GET: CyberSecurity
        public ViewResult Modules()
        {

            //CyberSecurity Modules0
            Cyber_security CSModel = new Cyber_security();
            CSModel.ModuleCode = "SE3901";
            CSModel.ModuleTitle = "C Programming.";
            CSModel.ModuleDescription = "C is a general-purpose computer programming language. It was created in the 1970s and remains very widely used and influential. By design, C's features cleanly reflect the capabilities of the targetted CPUs.";
            CSModel.ModuleContents = "Foundations of c ";
            CSModel.StaffMembers = "Dr.will, Dr. smith";

            //CyberSecurity Modules1
            Cyber_security CSModel1 = new Cyber_security();
            CSModel.ModuleCode1 = "SE3902";
            CSModel.ModuleTitle1 = "Computer Law and Cyber Security Management.";
            CSModel.ModuleDescription1 = "Cyber security is the application of technologies, processes and controls to protect systems, networks, programs, devices and data from cyber attacks. It aims to reduce the risk of cyber attacks and protect against the unauthorised exploitation of systems, networks and technologies.";
            CSModel.ModuleContents1 = "cyber law";
            CSModel.StaffMembers1 = "Prof.tom, elizabeth olsen";

            //CyberSecurity Modules2
            Cyber_security CSModel2 = new Cyber_security();
            CSModel.ModuleCode2 = "SE3903";
            CSModel.ModuleTitle2 = "Linux Security.";
            CSModel.ModuleDescription2 = "Security. From its very inception, security has been a cornerstone of the Linux operating system. Each user has to be walled off from others, and a password and user ID are required for an individual to use Linux.";
            CSModel.ModuleContents2 = "cyber security.";
            CSModel.StaffMembers2 = "Prof rockhold, Dr. robert";

            //CyberSecurity Modules3
            Cyber_security CSModel3 = new Cyber_security();
            CSModel.ModuleCode3 = "SE3904 ";
            CSModel.ModuleTitle3 = "Cyber Threat Intelligence and Incident Response.";
            CSModel.ModuleDescription3 = "Threat intelligence, or cyber threat intelligence, is information an organization uses to understand the threats that have, will, or are currently targeting the organization. This info is used to prepare, prevent, and identify cyber threats looking to take advantage of valuable resources.";
            CSModel.ModuleContents3 = "Operational, tactical, and strategic.";
            CSModel.StaffMembers3 = "Michael jewekes";

            //CyberSecurity Modules4
            Cyber_security CSModel4 = new Cyber_security();
            CSModel.ModuleCode4 = "SE3905";
            CSModel.ModuleTitle4 = "Malware Analysis.";
            CSModel.ModuleDescription4 = "Malware analysis is the process of understanding the behavior and purpose of a suspicious file or URL. The output of the analysis aids in the detection and mitigation of the potential threat.";
            CSModel.ModuleContents4 = "Understanding of malware.";
            CSModel.StaffMembers4 = "Professor Cox.";

            //CyberSecurity Modules5
            Cyber_security CSModel5 = new Cyber_security();
            CSModel.ModuleCode5 = "IMAT3611";
            CSModel.ModuleTitle5 = "Computer Ethics and Privacy.";
            CSModel.ModuleDescription5 = "Privacy in computer ethics refers to the ethical dilemmas that computer users face in some situations that may lead to the violation of another person's privacy through the use of computers. Ethics is a reference to a sense of what is right and wrong.";
            CSModel.ModuleContents5 = "computer privacy";
            CSModel.StaffMembers5 = "Prof jessica, liam";

            //CyberSecurity Modules6
            Cyber_security CSModel6 = new Cyber_security();
            CSModel.ModuleCode6 = "SE3451";
            CSModel.ModuleTitle6 = " Development Project.";
            CSModel.ModuleDescription6 = "Development Project means any construction, development or infrastructure project, including without limitation greenfield projects and brownfield projects, in which the Company or any of its Subsidiaries participates or holds, directly or indirectly, an interest, or the bidding on any such project.";
            CSModel.ModuleContents6 = "Team development project.";
            CSModel.StaffMembers6 = "Dr.martin, Prof holland";

            return View(CSModel);
        }
    }
}
