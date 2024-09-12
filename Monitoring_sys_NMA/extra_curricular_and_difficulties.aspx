<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="extra_curricular_and_difficulties.aspx.cs" Inherits="Monitoring_sys_NMA.extra_curricular_and_difficulties" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin-left: 50px; margin-right: 50px; margin-top: 100px; background-color: ghostwhite; margin-bottom: 50px;">

        <%--  statr form--%>
        <asp:Panel ID="Panel3" runat="server" Font-Bold="True" Font-Overline="False" BorderColor="WhiteSmoke" Font-Size="XX-Small" GroupingText="CO & EXTRA CURRICULAR ACTIVITIES FOR THE WEEK" BackColor="White" ForeColor="#000099">

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">SCHOOL</label>
                    <asp:TextBox ID="TextBox1" Enabled="false" runat="server" CssClass="form-control" BackColor="#CCCCCC"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">COURSE/BATCH</label>
                    <asp:TextBox ID="TextBox9" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">SERIAL-NO</label>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">DATE</label>
                    <asp:TextBox ID="TextBox3" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">ACTIVITY</label>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">INSTRUCTOR</label>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">NO'S OF TRAINEES</label>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">DESCRIPTION</label>
                    <asp:TextBox ID="TextBox7" TextMode="MultiLine" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-4">
                    <asp:Button ID="extra_activities" runat="server" Text="+Add To List" CssClass="btn btn-primary" OnClick="extra_activities_Click" Font-Bold="True" />
                </div>
            </div>
        </asp:Panel>

        <%-- end form--%>

        <div class="row">


            <asp:GridView ID="GridView1" Width="900" DataKeyNames="id" AutoGenerateColumns="False" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowDeleting="GridView1_RowDeleting" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
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
        <br />
        <br />
        <%-- next part--%>
        <asp:Panel ID="Panel1" runat="server" Font-Bold="True" Font-Overline="False" BorderColor="WhiteSmoke" Font-Size="XX-Small" GroupingText="DEFAULTERS LIST FOR THE WEEK" BackColor="White" ForeColor="#000099">

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">SERIAL-NO</label>
                    <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">DATE</label>
                    <asp:TextBox ID="TextBox8" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">RANK/RATE/OFF_NO/NAME</label>
                    <asp:TextBox ID="TextBox11" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">REASON</label>
                    <asp:TextBox ID="TextBox12" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">ACTION_TAKEN</label>
                    <asp:TextBox ID="TextBox13" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

            </div>

            <div class="row">
                <div class="form-group col-md-4">
                    <asp:Button ID="btn_default" runat="server" CssClass="btn btn-primary" Text="+Add To List" OnClick="btn_default_Click" Font-Bold="True" Font-Size="Medium" />
                </div>
            </div>
        </asp:Panel>

        <div class="row">


            <asp:GridView ID="GridView2" Width="900" DataKeyNames="id" AutoGenerateColumns="False" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowDeleting="GridView2_RowDeleting" OnRowCancelingEdit="GridView2_RowCancelingEdit" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating">
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
        <br />
        <br />
        <%-- next_part--%>

        <asp:Panel ID="Panel2" runat="server" Font-Bold="True" Font-Overline="False" BorderColor="WhiteSmoke" Font-Size="XX-Small" GroupingText="SUMMERY OF SICK REPORT/DRAFT/LEAVE/WITHDRAWAL" BackColor="White" ForeColor="#000099">

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">SERIAL-NO</label>
                    <asp:TextBox ID="TextBox14" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">DATE</label>
                    <asp:TextBox ID="TextBox15" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">RANK/RATE/OFF_NO/NAME</label>
                    <asp:TextBox ID="TextBox16" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">REASON</label>
                    <asp:TextBox ID="TextBox17" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="exampleInputPassword1" style="font-size: medium">DESCRIPTION(SICK PLACEMENR/DRAFT SIGNAL/LEAVE)</label>
                    <asp:TextBox ID="TextBox18" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

            </div>

            <div class="row">
                <div class="form-group col-md-4">
                    <asp:Button ID="defaulr_2" runat="server" CssClass="btn btn-primary" Text="+Add To List" OnClick="defaulr_2_Click" Font-Bold="True" />
                </div>
            </div>
        </asp:Panel>

        <div class="row">


            <asp:GridView ID="GridView3" Width="900" DataKeyNames="id" AutoGenerateColumns="False" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowDeleting="GridView3_RowDeleting" OnRowCancelingEdit="GridView3_RowCancelingEdit" OnRowEditing="GridView3_RowEditing" OnRowUpdating="GridView3_RowUpdating">
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

        <%--  end--%>




        <br />
        <div class="row">
            <div class="form-group col-md-4">
                <%-- <asp:Button ID="Button3" runat="server" CssClass="btn btn-primary" Text="--> NEXT" OnClick="Button3_Click" />--%>
                <asp:Button ID="Button1" runat="server" Text="--> NEXT" CssClass="btn btn-primary" OnClick="Button1_Click" Font-Bold="True" />
            </div>
        </div>


    </div>

</asp:Content>
