<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Comp229_Assign04.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
          <asp:Repeater ID="ModelsShow" runat="server">
                <ItemTemplate>
                    <div class="col-sm-4">
                        <div class="contentModel">
                            <div class="infoModel">
                                <div class="nameModel">
                                    <a href="ModelPage.aspx?model=<%# Eval("Name") %>">
                                        <asp:Label ID="ModelLabel" Text='<%# Eval("Name") %>' runat="server" /></span>
                                    </a>
                                </div>
                                <div class="imageModel">
                                    <a href="ModelPage.aspx?model=<%# Eval("Name") %>">
                                        <asp:Image ID="ModelImage"
                                            AlternateText='<%# Eval("Name") %>'
                                            ImageUrl='<%# Eval("ImageUrl") %>'
                                            CssClass="smallModel"
                                            runat="server" />
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <div class="col-sm-12" style="display: block; overflow: auto;" />
            <br /><hr /><br />
            <div class="emailNameBox">
                    <div class="col-sm-5">
                        <asp:TextBox ID="EmailNameTextBox"
                            TextMode="SingleLine"
                            runat="server"
                            placeholder="Name" />
                    </div>
                    <div class="col-sm-5">
                        <asp:TextBox ID="EmailTextBox"
                            TextMode="Email"
                            runat="server"
                            placeholder="Email (email@email.com)" />
                    </div>                    
                    <div class="col-sm-2">
                    <%--<asp:Button ID="SendEmail"
                            Text=""
                            OnClick=""
                            ValidationGroup=""
                            runat="server" />--%>
                    </div>
                </div>
            
</asp:Content>
