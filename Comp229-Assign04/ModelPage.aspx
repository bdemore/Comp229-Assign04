<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModelPage.aspx.cs" Inherits="Comp229_Assign04.ModelPage" %>
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
            
</asp:Content>
