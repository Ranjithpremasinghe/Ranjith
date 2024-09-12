<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Monitoring_sys_NMA.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>


    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="margin-left: 50px; margin-right: 50px; margin-top: 40px; background-color: ghostwhite; margin-bottom: 50px;">

            <div class="container">
                <div class="row">

                    <%--data insert--%>
                    <div class="col-5">
                        <asp:Panel ID="Panel1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Medium" GroupingText="ADD NEW USER" BackColor="White" ForeColor="#000099">
                            <hr />
                            <div class="form-group">
                                <label for="exampleInputPassword1" style="font-size: medium">SCHOOL</label>
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>                              
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="exampleInputEmail1" style="font-size: medium">Select Your Role</label>
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>                              
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="exampleInputPassword1" style="font-size: medium">Email</label>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Add Your Email"></asp:TextBox>                              
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="exampleInputPassword1" style="font-size: medium">Password</label>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Add Your Password" TextMode="Password"></asp:TextBox>                                
                            </div>
                            &nbsp;<br />
                            Confirm Password
                            <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" placeholder="Add Your Password" TextMode="Password"></asp:TextBox>
                            <br />
                            <div class="form-group">
                                <asp:Button ID="Button1" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="Button1_Click1" Font-Bold="True" Font-Size="Medium"/>
                               
                            </div>
                            <div class="form-group">
                                <asp:Label ID="Label1" runat="server" CssClass="form-group" ForeColor="Red"></asp:Label>
                            </div>
                        </asp:Panel>

                    </div>


                    <%--  grid view--%>
                    <div class="col-7">

                        <div class="row">
                            <div class="col-8">
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Please Enter User Role Category"></asp:TextBox>
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button2" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="Button2_Click" Font-Bold="True" />
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="id" Width="700px" AutoGenerateColumns="False" AllowPaging="true" PageSize="4" OnRowDeleting="GridView1_RowDeleting">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="SCHOOL" DataField="school">
                                        <HeaderStyle Width="120px"></HeaderStyle>
                                    </asp:BoundField>
                                     <asp:BoundField HeaderStyle-Width="120px" HeaderText="ROLE" DataField="role">
                                        <HeaderStyle Width="120px"></HeaderStyle>
                                    </asp:BoundField>
                                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="EMAIL" DataField="email">
                                        <HeaderStyle Width="120px"></HeaderStyle>
                                    </asp:BoundField> 
                                   
                                 
                                    <asp:CommandField ShowDeleteButton="true" ControlStyle-CssClass="btn btn-danger" HeaderText="Remove Record">

                                        <ControlStyle CssClass="btn btn-danger"></ControlStyle>
                                    </asp:CommandField>

                                </Columns>
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            </asp:GridView>
                        </div>

                    </div>


                </div>
            </div>

            <%-- user registration--%>
            <hr />

            <div class="container">
                <div class="row">
                    <div class="col-5">
                        <asp:Panel ID="Panel2" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Medium" GroupingText="++ ADD SCHOOL" BackColor="White" ForeColor="#000099">
                            <hr />

                            <div class="form-group">
                                <label for="exampleInputEmail1" style="font-size: medium">Enter School Name</label>
                                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" placeholder="School Name"></asp:TextBox>
                               
                            </div>

                            <br />
                            <div class="form-group">
                                <asp:Button ID="Button3" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="Button3_Click" Font-Bold="True" Font-Size="Medium" />
                            </div>
                            <br />


                        </asp:Panel>
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" CssClass="form-group" ForeColor="Red"></asp:Label>
                        </div>
                    </div>







                </div>
            </div>





        </div>










    </form>
</body>
</html>
