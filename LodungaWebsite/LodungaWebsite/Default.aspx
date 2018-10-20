<%@ Page Title="Lodunga Technical" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LodungaWebsite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <br /><br />
    <div >

        <div id="carousel-example-generic" class="carousel slide " data-ride="carousel" >
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                <li data-target="#carousel-example-generic" data-slide-to="3"></li>
                <li data-target="#carousel-example-generic" data-slide-to="4"></li>
                <li data-target="#carousel-example-generic" data-slide-to="5"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner" role="listbox" >
                <div class="item active" >
                    <img src="Images/1.jpg" alt="..." class="center-block img-responsive">
                    <div class="carousel-caption">
                        <p>Alarms</p>
                    </div>
                </div>
                <div class="item" >
                    <img src="Images/2.jpg" alt="..." class="center-block img-responsive">
                    <div class="carousel-caption">
                        <p>Intercom</p>
                    </div>
                </div>
                <div class="item">
                    <img src="Images/3.jpg" alt="..." class="center-block img-responsive">
                    <div class="carousel-caption">
                        <p>Access Control</p>
                    </div>
                </div>
                <div class="item" ">
                    <img src="Images/4.jpg" alt="..." class="center-block img-responsive">
                    <div class="carousel-caption">
                        <p>CCTV Installation and Offsite monitoring</p>
                    </div>
                </div>
                <div class="item" >
                    <img src="Images/5.jpg" alt="..." class="center-block img-responsive">
                    <div class="carousel-caption">
                        <p>Gate Automation</p>
                    </div>
                </div>
                <div class="item" >
                    <img src="Images/6.jpg" alt="..." class="center-block img-responsive">
                    <div class="carousel-caption">
                        <p>Electric Fancing</p>
                    </div>
                </div>
                <%--...--%>
            </div>

            <!-- Controls -->
            <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>

    

    

    <%--  --%>
    <div class="row">
        <div class="col-md-4">
            <h2>OUR RESOURCES</h2>
            <p>

                The right people are our greatest resources, it is therefore pivotal that LODUNGA TECHNICAL has

                the right people on the bus before starting the journey to excellence. Providing quality products and

                services relies on the involvement of the people for the ultimate success in all processes and

                strategies. We ensure that our people have the right, adequate capabilities and skills to satisfy the

                client’s requirements. The employees working within the company have solid experience and

                capability in areas of expertise and deeper specialized skills.

  
            </p>
            
        </div>
        <div class="col-md-4">
            <h2>QUALITY</h2>
            <p>
                We pay special attention to the quality assurance of the products and services we deliver. We believe

                this is the way to make products function in an effective and satisfactory manner. Our clients can rely

                on our products working properly and as specified. By investing in quality assurance we invest in our

                customer’s business success, and thus value.
   
            </p>
            
        </div>
        <div class="col-md-4">
            <h2>VISION</h2>
            <p>
              To become a leader in the provision of globally acknowledged services in security systems.
            </p>
           
        </div>
    </div>
        </div>

</asp:Content>
