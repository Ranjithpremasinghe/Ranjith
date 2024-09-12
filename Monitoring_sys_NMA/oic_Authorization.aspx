<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="oic_Authorization.aspx.cs" Inherits="Monitoring_sys_NMA.oic_Authorization" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div style="margin-left: 50px; margin-right: 50px; margin-top: 100px; background-color: ghostwhite; margin-bottom: 50px;">
        <asp:Panel ID="Panel3" runat="server" Font-Bold="True" Font-Overline="False" BorderColor="WhiteSmoke" Font-Size="Medium" GroupingText="OIC  AUTHORIZATION" BackColor="White" ForeColor="#000099">

            <%-- first--%>
            <div class="row">
                  <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">SCHOOL</label>
                    <asp:TextBox ID="TextBox15" runat="server" CssClass="form-control"></asp:TextBox>                  
                </div>
            </div>
           

            <div class="row">
                <h3>CHRONOLOGICAL SEQUENCE OF RECORDS</h3>
                <asp:GridView ID="GridView1" Width="900" DataKeyNames="id" AutoGenerateColumns="False" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
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
             <br />


            <%-- second--%>

               <div class="row">

                   <h3>DEVIATION FROM PROGRAMMED SCHEDULE</h3>
            <asp:GridView ID="GridView2" Width="900" DataKeyNames="id" AutoGenerateColumns="False" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowCancelingEdit="GridView2_RowCancelingEdit" OnRowDeleting="GridView2_RowDeleting" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating" >
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
             <br />

           <%-- third--%>

             <div class="row">
                 <h3>CO & EXTRA CURRICULAR ACTIVITIES FOR THE WEEK</h3>

            <asp:GridView ID="GridView3" Width="900" DataKeyNames="id" AutoGenerateColumns="False" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowCancelingEdit="GridView3_RowCancelingEdit" OnRowDeleting="GridView3_RowDeleting" OnRowEditing="GridView3_RowEditing" OnRowUpdating="GridView3_RowUpdating" >
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
                            <asp:Label runat="server" Text='<%#Eval("date")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtdate" runat="server" Text='<%#Bind("date") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ACTIVITY">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("activity")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtact" runat="server" Text='<%#Bind("activity") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="INSTRUCTOR">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("instructor")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txINS" runat="server" Text='<%#Bind("instructor") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="TRANEE">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("tranee")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTR" runat="server" Text='<%#Bind("tranee") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="DESCRIPTION">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("description")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDIS" runat="server" Text='<%#Bind("description") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                   
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
             <br />

           <%-- four--%>

            
        <div class="row">
            <h3>DEFAULTERS LIST FOR THE WEEK</h3>
            <asp:GridView ID="GridView4" Width="900" DataKeyNames="id" AutoGenerateColumns="False" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowCancelingEdit="GridView4_RowCancelingEdit" OnRowDeleting="GridView4_RowDeleting" OnRowEditing="GridView4_RowEditing" OnRowUpdating="GridView4_RowUpdating" >
                <Columns>
                    <asp:TemplateField HeaderText="SR_NO">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("sr_no")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtsr" runat="server" Text='<%#Bind("sr_no") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="RANK/RATE/OFF NO/NAME">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("rank_name")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtRNK" runat="server" Text='<%#Bind("rank_name") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="REASON">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("reason")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtRSN" runat="server" Text='<%#Bind("reason") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ACTION TAKEN">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("action")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txACT" runat="server" Text='<%#Bind("action") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
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
             <br />

           <%-- five--%>


              <div class="row">
                  <h3>SUMMERY OF SICK REPORT/DRAFT/LEAVE/WITHDRAWAL</h3>
            <asp:GridView ID="GridView5" Width="900" DataKeyNames="id" AutoGenerateColumns="False" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowCancelingEdit="GridView5_RowCancelingEdit" OnRowDeleting="GridView5_RowDeleting" OnRowEditing="GridView5_RowEditing" OnRowUpdating="GridView5_RowUpdating" >
                <Columns>

                    <asp:TemplateField HeaderText="SR_NO">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("srno")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtsr" runat="server" Text='<%#Bind("srno") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="RANK/RATE/OFF NO/NAME">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("rank_name")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtRNK" runat="server" Text='<%#Bind("rank_name") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="REASON">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("reason")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtRSN" runat="server" Text='<%#Bind("reason") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="DESCRIPTION">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("description")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txDES" runat="server" Text='<%#Bind("description") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                   
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
            <br />
           <%-- SIX--%>

              <div class="row">
                  <h3>WEEKLY WORKING PARTY EMPLOYMENT</h3>

            <asp:GridView ID="GridView6" Width="900px" DataKeyNames="id" AutoGenerateColumns="False" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowCancelingEdit="GridView6_RowCancelingEdit" OnRowDeleting="GridView6_RowDeleting" OnRowEditing="GridView6_RowEditing" >
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
                            <asp:Label runat="server" Text='<%#Eval("date")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDTEK" runat="server" Text='<%#Bind("date") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="TIME_FROM">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("time_from")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTF" runat="server" Text='<%#Bind("time_from") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="TIME_TO">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("time_to")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txTTO" runat="server" Text='<%#Bind("time_to") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                      <asp:TemplateField HeaderText="TASK">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("task")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txTSK" runat="server" Text='<%#Bind("task") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                      <asp:TemplateField HeaderText="STRENGTH">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("strength")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txSTR" runat="server" Text='<%#Bind("strength") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="DESCRIPTION">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("description")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txDES" runat="server" Text='<%#Bind("description") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
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
           <br />


           <%-- SEVEN--%>

              <div class="row">
                  <h3>OIC'S INTERVIES SHEDULE FOR THE WEEK</h3>

            <asp:GridView ID="GridView7" Width="900" DataKeyNames="id" AutoGenerateColumns="False" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowDeleting="GridView7_RowDeleting" OnRowEditing="GridView7_RowEditing" >
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
                            <asp:Label runat="server" Text='<%#Eval("date")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDTE" runat="server" Text='<%#Bind("date") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="TIME_FROM">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("timeFrom")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTF" runat="server" Text='<%#Bind("timeFrom") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="TIME_TO">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("timeTo")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txTTO" runat="server" Text='<%#Bind("timeTo") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                      <asp:TemplateField HeaderText="TRAINEES_DETAILS">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("details")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txDTLS" runat="server" Text='<%#Bind("details") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="REMARKS">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("remarks")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txREMK" runat="server" Text='<%#Bind("remarks") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>                    
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
        </asp:Panel>
        <br />
        <div class="row">
            <asp:Button ID="Button2" runat="server" CssClass="btn btn-success" Text="Save & Forward" OnClick="Button2_Click"/>
        </div>
        
    </div>

</asp:Content>
