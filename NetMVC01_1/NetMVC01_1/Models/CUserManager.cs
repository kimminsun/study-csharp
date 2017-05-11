using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Linq;

namespace NetMVC01_1.Models
{
    public class CUserManager
    {
        //private List<CUser> theUsers;

        LUserDataContext theUserContext;

        public CUserManager()
        {
         //   theUsers = new List<CUser>();
            theUserContext = new LUserDataContext();
        }
        public int AddUser(ref CUser aUser)
        {
        //    CUser tmpUser = new CUser();
        //    tmpUser.theUniqueID = 0;
            //tmpUser.theDate = DateTime.Now;

            string tmpID = aUser.theID;
            int tmpCount = theUserContext.TUser3102.Where( x => x.theID == tmpID ).Count();
            if(tmpCount>0)
            {
                return (0);
            }

            TUser3102 tmpUser = new TUser3102();
            tmpUser.theID = aUser.theID;
            tmpUser.thePW = aUser.thePW;
            tmpUser.theName = aUser.theName;
            tmpUser.theEMail = aUser.theEMail;
            tmpUser.bSubcription = aUser.bSubscription ? 1 : 0;
            tmpUser.theDate = DateTime.Now;

            theUserContext.TUser3102.InsertOnSubmit( tmpUser );
            theUserContext.SubmitChanges();

            aUser.theDate = DateTime.Now;
            return (1);
        }
        public List<CUser> GetUsers()
        {
            IQueryable<TUser3102> tmpR = theUserContext.TUser3102.OrderByDescending( x => x.theID );
            //쿼리를 가져오는것 

            List<TUser3102> tmpL = tmpR.ToList<TUser3102>();
            List<CUser> resUsers = new List<CUser>();
            foreach(TUser3102 iter in tmpL)
            {
                CUser tmpUser = new CUser();
                tmpUser.theUniqueID = iter.theUniqueID;
                tmpUser.theID = iter.theID;
                tmpUser.thePW = iter.thePW;
                tmpUser.theName = iter.theName;
                tmpUser.theEMail = iter.theEMail;
                tmpUser.bSubscription = iter.bSubcription == 1 ? true : false;
                tmpUser.theDate = iter.theDate;
                resUsers.Add( tmpUser );

            }
            return (resUsers);
        }
        public int CheckUser(string aID, string aPW,out CUser aUser)
        {
            //foreach (CUser iter in theUsers)
            //{
            //    if (iter.theName.Equals(aID) == true && iter.thePW.Equals(aPW) == true)
            //    {
            //        return (1);
            //    }
            //}
            Table<TUser3102> users = theUserContext.GetTable<TUser3102>();
            IQueryable<TUser3102> tmpQ = from iter in users
                                         where iter.theID == aID && iter.thePW == aPW
                                         select iter;

            if(tmpQ.Count()>0)
            {
                List<TUser3102> tmpUser = tmpQ.Take( 1 ).ToList();
                aUser = new CUser();
                aUser.theID = tmpUser[ 0 ].theID;
                aUser.thePW = tmpUser[ 0 ].thePW;
                aUser.theName = tmpUser[ 0 ].theName;
                aUser.theEMail = tmpUser[ 0 ].theEMail;
                aUser.bSubscription = tmpUser[ 0 ].bSubcription == 1 ? true : false;
                aUser.theDate = tmpUser[ 0 ].theDate;
                return (1);
            }
            aUser = new CUser();
            return (0);
        }
    }
}


        