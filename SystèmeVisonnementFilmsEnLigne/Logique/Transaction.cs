
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meVisonnementFilmsEnLigne.Logique
{
public class Transaction : DomainObject
 {
		private string mNum�ro;
		public string Num�ro {
    			get {
      				return  mNum�ro;
    			}
    			set {
      				mNum�ro=value;
    			}
		    }
		private DateTime mDateTransaction;
		public DateTime DateTransaction {
    			get {
      				return  mDateTransaction;
    			}
    			set {
      				mDateTransaction=value;
    			}
		    }
		private string mTypeTransaction;
		public string TypeTransaction {
    			get {
      				return  mTypeTransaction;
    			}
    			set {
      				mTypeTransaction=value;
    			}
		    }
		private float mPrix;
		public float Prix {
    			get {
      				return  mPrix;
    			}
    			set {
      				mPrix=value;
    			}
		    }
		private float mMontantTaxe;
		public float MontantTaxe {
    			get {
      				return  mMontantTaxe;
    			}
    			set {
      				mMontantTaxe=value;
    			}
		    }
	
		private Guid mIDSession;
		public Guid IDSession
        	{
            		get { return mIDSession; }
            		set { mIDSession = value; }
        	}
	public Transaction[] consuterHistorique(Client client)
    
    {
    // to add your business logic code of the operation

    return null;
    }
  
 
 }
}	
       