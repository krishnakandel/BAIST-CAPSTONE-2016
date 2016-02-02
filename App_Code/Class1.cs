using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
        Member AuthenticatedMember;
        AuthenticatedMember = new Member();

        Users UserManager;
        UserManager = new Users();

        AuthenticatedMember = UserManager.GetUser(UserName, Password);
        return AuthenticatedMember;	//
		// TODO: Add constructor logic here
		//
	}
}