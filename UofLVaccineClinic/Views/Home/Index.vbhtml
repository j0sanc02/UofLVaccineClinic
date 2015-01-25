@Code
    ViewData("Title") = "Home Page"
End Code

<head>
    <title>
        Home Page
    </title>
    <link rel="stylesheet" type="text/css" href="~/Content/CSS/HomeStyle.css">
</head>

<br />
<br />
<br />
<br />
<br />
<div class="alert alert-warning" role="alert" style="text-align:right"><i class="glyphicon glyphicon-warning-sign attention!"> Attention! A patient has requested an appointment and it needs approval.   </i><i class="glyphicon glyphicon-remove"></i></div>
<div class="row">
    <div class="col-md-2">
        <p>
            <div class="btn-group-vertical btn-group-lg" aria-label="...">

                <a class="btn dropdown-toggle" data-toggle="dropdown" role="button" href="www.google.com">
                    <img src="~/Content/Images/Syringe.png" alt="Inventory" style="width:75px; height:50px" />
                    <br />Inventory &raquo;<i class="icon icon-caret-right"></i>
                </a>
                <ul class="dropdown-menu">
                    <li>Add Vaccine</li>
                    <li>Modify Vaccine</li>
                    <li>Delete Vaccine</li>
                </ul>



                <a class="btn dropdown-toggle" data-toggle="dropdown" role="button" href="www.google.com"><img src="~/Content/Images/Calendar.jpg" alt="Inventory" style="width:75px; height:50px" /><br />Scheduling &raquo;</a>


                <a class="btn dropdown-toggle" data-toggle="dropdown" role="button" href="www.google.com"><img src="~/Content/Images/Document.png" alt="Inventory" style="width:75px; height:50px" /><br />Grants &raquo;</a>


                <a class="btn dropdown-toggle" data-toggle="dropdown" role="button" href="www.google.com"><img src="~/Content/Images/User.png" alt="Inventory" style="width:75px; height:50px" /><br />Users &raquo;</a>
            </div>
        </p>
    </div>
    <div class="col-md-1"></div>
    <div class="col-md-7">
        <img src="~/Content/Images/FullCalendar.png" alt="Inventory" style="width:100%; height: 400px"/>
    </div>
    <div class="col-md-2">
        <p> Messaging System</p>
    </div>
</div>