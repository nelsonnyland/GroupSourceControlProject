﻿using GroupSourceControlProject.ObjClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject
{
    /// <summary>
    /// The MemberDB class communicates with the database and
    /// handles current logged-in member as well as registration
    /// log-in and some Member class methods.
    /// </summary>
    public static class MemberDB
    {
        /// <summary>
        /// Returns all members in the database.
        /// </summary>
        /// <returns></returns>
        public static List<Member> GetAllMembers()
        {
            LibraryContext context = new LibraryContext();

            List<Member> allMembers =
                (from m in context.Members
                 select m).ToList();

            return allMembers;
        }

        /// <summary>
        /// Checks if the member passed in matches just 
        /// username of a member in the database. 
        /// If so, returns true, false otherwise.
        /// </summary>
        /// <param name="member"></param>
        /// <returns>bool verification result</returns>
        public static bool IsMember(Member member)
        {
            List<Member> allMembers = GetAllMembers();

            foreach (Member item in allMembers)
            {
                if (item.Username == member.Username)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the member passed in matches both the 
        /// username and PIN of a member in the database. 
        /// If so, the user is logged-in.
        /// </summary>
        /// <param name="member"></param>
        public static bool LogIn(Member member)
        {
            List<Member> allMembers = GetAllMembers();

            foreach (Member dbMember in allMembers)
            {
                if ((dbMember.Username == member.Username) 
                    && (dbMember.PIN == member.PIN))
                {
                    SetMember(dbMember);
                    return true;
                }
            }

            return false;
        }
        
        /// <summary>
        /// Adds a member to the database.
        /// </summary>
        /// <param name="member"></param>
        public static bool Register(Member member)
        {
            LibraryContext context = new LibraryContext();

            context.Members.Add(member);

            context.SaveChanges();

            return IsMember(member);
        }

        /// <summary>
        /// Sets the current member logged-in to the website.
        /// </summary>
        /// <param name="member"></param>
        private static void SetMember(Member member)
        {
            CurrentMember.SetCurrentMember(member);
        }

        /// <summary>
        /// Creates a custom member id for new members.
        /// </summary>
        /// <returns></returns>
        public static string CreateMemberID()
        {
            List<Member> members = GetAllMembers();

            int intMemberID = 100000000 + members.Count + 1;

            string memberID = intMemberID.ToString();

            return memberID;
        }

        /// <summary>
        /// Removes member from the database.
        /// </summary>
        /// <param name="memberId"></param>
        public static void RemoveMember(string memberId)
        {
            LibraryContext context = new LibraryContext();

            Member member = context.Members.Find(memberId);
            
            context.Members.Remove(member);

            context.SaveChanges();
        }
    }
}
