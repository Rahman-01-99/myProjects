function valid()
    {
        //Name
        a=document.getElementById("firstname");
        e1=document.getElementById("erbox1");
        exp1=/^[A-Z a-z]{3,10}$/;
        if(a.value=="")
        {
            e1.innerHTML="Enter First Name";
            a.focus();
            return false;
        }
        else if(exp1.test(a.value)==false)
        {
            e1.innerHTML="Enter Valid Name";
            a.focus();
            return false;
        }
        else
        {
            e1.innerHTML="";
        }
        b=document.getElementById("lastname");
        e2=document.getElementById("erbox2");
        exp1=/^[A-Z a-z]{3,10}$/;
        if(b.value=="")
        {
            e2.innerHTML="Enter Last Name";
            b.focus();
            return false;
        }
        else if(exp2.test(b.value)==false)
        {
            e2.innerHTML="Enter Valid Name";
            b.focus();
            return false;
        }
        else
        {
            e2.innerHTML="";
        }

        //Father's Name
        c=document.getElementById("ffname");
        e3=document.getElementById("erbox3");
        exp3=/^[A-Z a-z]{3,10}$/;
        if(c.value=="")
        {
            e3.innerHTML="Enter First Name";
            c.focus();
            return false;
        }
        else if(exp3.test(c.value)==false)
        {
            e3.innerHTML="Enter Valid Name";
            c.focus();
            return false;
        }
        else
        {
            e3.innerHTML="";
        }
        d=document.getElementById("flname");
        e4=document.getElementById("erbox4");
        exp4=/^[A-Z a-z]{3,10}$/;
        if(d.value=="")
        {
            e4.innerHTML="Enter Last Name";
            d.focus();
            return false;
        }
        else if(exp4.test(d.value)==false)
        {
            e4.innerHTML="Enter Valid Name";
            d.focus();
            return false;
        }
        else
        {
            e4.innerHTML="";
        }
    }
