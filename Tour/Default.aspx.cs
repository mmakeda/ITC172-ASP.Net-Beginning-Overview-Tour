﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    /*This is a multiline comment. It's a good idea
    to put a header comment for every class */


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        GetTimeTillBirthday();
    }

    protected void GetTimeTillBirthday()
    {
        DateTime birthDay;


        if (Calendar1.SelectedDate == null)
        {
            birthDay = DateTime.Now;
        }
        else
        {
            birthDay = Calendar1.SelectedDate;
        }
        Response.Write(birthDay);
        string name = NameTextBox.Text;

        //this calculates the time until the birthday
        TimeSpan daysUntilBirthday = birthDay.Subtract(DateTime.Now);
        ResultLabel.Text = "Days until Birthday " +
            Math.Abs(daysUntilBirthday.Days).ToString() +
            ". And this many hours "
         + Math.Abs(daysUntilBirthday.Hours).ToString();

    }

}
