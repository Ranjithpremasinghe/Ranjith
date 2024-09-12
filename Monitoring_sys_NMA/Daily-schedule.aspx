 <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Daily-schedule.aspx.cs" Inherits="Monitoring_sys_NMA.Daily_schedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-left: 50px; margin-right: 50px; margin-top: 100px; background-color: ghostwhite; margin-bottom: 50px;">

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        &nbsp;<%--  statr form--%><asp:Panel ID="Panel3" runat="server" Font-Bold="True" Font-Overline="False" BorderColor="WhiteSmoke" Font-Size="XX-Large" GroupingText="CHRONOLOGICAL SEQUENCE OF RECORDS" BackColor="White" ForeColor="#0000CC" Font-Strikeout="False" Font-Underline="False">

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">SCHOOL</label>
                    <asp:TextBox ID="TextBox15" runat="server" CssClass="form-control"></asp:TextBox>
                    <%--<asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>--%>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">COURSE/BATCH</label>
                    <asp:TextBox ID="txtCourse" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">SERIAL-NO</label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCourse" Display="Dynamic" ErrorMessage=" * Required" ForeColor="Red" Font-Size="Medium"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">DATE</label>
                    <asp:TextBox ID="TextBox3" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">START_TIME</label>
                    <asp:TextBox ID="TextBox4" TextMode="Time" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">END_TIME</label>
                    <asp:TextBox ID="TextBox5" TextMode="Time" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">SUBJECT</label>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">INSTRUCTOR</label>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group col-md-4" style="font-size: medium">
                    <label for="exampleInputPassword1">TOPIC COVER ACTIVITIES</label>
                    <asp:TextBox ID="TextBox8" TextMode="MultiLine" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group col-md-4">
                    <asp:Button ID="btn_daily_schedule" runat="server" Text="+Add To List" CssClass="btn btn-primary" OnClick="btn_daily_schedule_Click" Font-Bold="True" Font-Overline="False" Font-Size="Medium" />
                </div>
            </div>
        </asp:Panel>

        <%-- end form--%>

        <div class="row">


            <asp:GridView ID="GridView1" Width="900" DataKeyNames="id" AutoGenerateColumns="False" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowDeleting="GridView1_RowDeleting" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                <Columns>

                 <asp:TemplateField HeaderText="SR_NO">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("sr_no")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                        
                            <asp:TextBox ID="txtsr" runat="server" Text='<%#Bind("sr_no") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                      <asp:TemplateField HeaderText="DATE">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("date")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                      
                            <asp:TextBox ID="txtdate" runat="server" Text='<%#Bind("date") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="START_TIME">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("st_time")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                   
                            <asp:TextBox ID="txtst" runat="server" Text='<%#Bind("st_time") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="END_TIME">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("end_time")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                           
                            <asp:TextBox ID="txtet" runat="server" Text='<%#Bind("end_time") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="SUBJECT">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("subject")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                          
                            <asp:TextBox ID="txtsbjt" runat="server" Text='<%#Bind("subject") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="INSTRUCTOR">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("instructor")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                         
                            <asp:TextBox ID="txtins" runat="server" Text='<%#Bind("instructor") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="ACTIVITIES" HeaderStyle-Width="300PX">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("activities")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                          
                            <asp:TextBox ID="txtact" runat="server" Text='<%#Bind("activities") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ShowEditButton="true" ControlStyle-CssClass="btn btn-success" HeaderText="EDIT" ControlStyle-Width="100px" ItemStyle-Width="120px" />
                    <asp:CommandField ShowDeleteButton="true" ControlStyle-CssClass="btn btn-danger" HeaderText="REMOVE" ItemStyle-Width="120px" />
                
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
        </div>
       <%-- next part--%>
        <asp:Panel ID="Panel1" runat="server" Font-Bold="True" Font-Overline="False" BorderColor="WhiteSmoke" Font-Size="XX-Small" GroupingText="DEVIATION FROM PROGRAMMED SCHEDULE" BackColor="White" ForeColor="#000099">

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">SERIAL-NO</label>
                    <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">DATE</label>
                    <asp:TextBox ID="TextBox1" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" spellcheck="false" style="font-size: medium">PROGRAMME SCHEDULE SUBJECT</label>
                    <asp:TextBox ID="TextBox11" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

            </div>

            <div class="row">

                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">DEVIATION(REFER APPROVAL)</label>
                    <asp:TextBox ID="TextBox12" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">INSTRUCTOR</label>
                    <asp:TextBox ID="TextBox13" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">REASON ARRANGEMRNT FOR DEVIATION</label>
                    <asp:TextBox ID="TextBox14" TextMode="MultiLine" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-4">
                    <asp:Button ID="btn_deviation" runat="server" CssClass="btn btn-primary" Text="+Add To List" OnClick="btn_deviation_Click" Font-Bold="True" />
                </div>
            </div>
        </asp:Panel>

        <div class="row">


            <asp:GridView ID="GridView2" Width="900" DataKeyNames="id" AutoGenerateColumns="False" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowDeleting="GridView2_RowDeleting" OnRowCancelingEdit="GridView2_RowCancelingEdit" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating">
                <Columns>

                    
                 <asp:TemplateField HeaderText="SR_NO">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("srno")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                        
                            <asp:TextBox ID="txtsr" runat="server" Text='<%#Bind("srno") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                      <asp:TemplateField HeaderText="DATE">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("dte")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                      
                            <asp:TextBox ID="txtdate" runat="server" Text='<%#Bind("dte") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="SUBJECT">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("subject")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                   
                            <asp:TextBox ID="txtsub" runat="server" Text='<%#Bind("subject") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="DEVIATION">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("deviation")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                           
                            <asp:TextBox ID="txtdv" runat="server" Text='<%#Bind("deviation") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="INSTRUCTOR">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("instructor")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                          
                            <asp:TextBox ID="txtins" runat="server" Text='<%#Bind("instructor") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                   

                     <asp:TemplateField HeaderText="REASONS" HeaderStyle-Width="300PX">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("reasons")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>                          
                            <asp:TextBox ID="txtact" runat="server" Text='<%#Bind("reasons") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>



                    <asp:CommandField ShowEditButton="true" ControlStyle-CssClass="btn btn-success" HeaderText="EDIT" ControlStyle-Width="100px" ItemStyle-Width="120px" />
                    <asp:CommandField ShowDeleteButton="true" ControlStyle-CssClass="btn btn-danger" HeaderText="REMOVE" ItemStyle-Width="120px" />

                  

                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
        </div>
        <br />
        <div class="row">
            <div class="form-group col-md-4">
                <asp:Button ID="Button3" runat="server" CssClass="btn btn-primary" Text="--> NEXT" OnClick="Button3_Click" Font-Bold="True" />
            </div>
        </div>


    </div>
</asp:Content>
