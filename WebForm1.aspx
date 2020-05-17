<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .headerCssClass{
            background-color:#c33803;
            color:white;
            border:1px solid black;
            text-align:center;
            padding:4px;
        }
       
        .contentCssClass{
            background-color:#e59a7d;
            color:black;
            border:1px dotted black;
            padding:4px;
        }
        .headerSelectedCss{
            background-color:#808080;
            color:white;
            border:1px solid black;
            padding:4px;
            text-align:center;
        }
    </style>
</head>
<body style="height: 610px">
    <form id="form1" runat="server">
        <div >
            <asp:Panel ID="Panel1" runat="server" BackColor="#494E6C" Height="108px">
                <asp:Image ID="Image1" runat="server" Height="109px" ImageUrl="~/image/logo.png" Width="240px" />
            
                <asp:Image ID="Image2" runat="server" Height="105px" ImageUrl="~/image/slogan.png" style="margin-left: 81px; margin-top: 0px" Width="855px" />
            
            </asp:Panel>
        </div>
        <div style="height: 415px; float:left; width: 241px;">

            <asp:Panel ID="Panel2" runat="server" Width="240px" BackColor="#FDB924" Height="500px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Nereden:"></asp:Label>
                &nbsp;<asp:DropDownList ID="dlFrom" runat="server" Height="23px" style="margin-left: 15px" Width="98px">
                    <asp:ListItem>Adana</asp:ListItem>
                    <asp:ListItem>Ankara</asp:ListItem>
                    <asp:ListItem Value="0">Bursa</asp:ListItem>
                    <asp:ListItem>İstanbul</asp:ListItem>
                    <asp:ListItem>İzmir</asp:ListItem>
                    <asp:ListItem>Eskişehir</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Nereye:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="dlTo" runat="server" Height="23px" style="margin-left: 0px" Width="98px">
                <asp:ListItem Value="0">Adıyaman</asp:ListItem>
                <asp:ListItem Value="1">Ankara</asp:ListItem>
                <asp:ListItem Value="2">Bursa</asp:ListItem>
                <asp:ListItem Value="3">İstanbul</asp:ListItem>
                <asp:ListItem Value="4">İzmir</asp:ListItem>
                <asp:ListItem Value="5">Eskişehir</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
            <br />
                &nbsp;&nbsp;&nbsp;<asp:Calendar ID="Calendar1" runat="server" Height="22px" style="margin-left: 12px" Width="22px"></asp:Calendar>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSorgula" runat="server" style="margin-left: 0px" Text="Sorgula" OnClick="btnSorgula_Click" Height="34px" Width="77px" BackColor="#494E6C" BorderStyle="Solid" ForeColor="#FDB924" />
            </asp:Panel>
            
    
</div>
        
 <asp:Panel ID="Panel3" runat="server" BackColor="White" Height="509px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Label ID="lbSonuc" runat="server" Font-Size="X-Large" Text="Sefer bulunamadı!" Visible="False"></asp:Label>
            
            <br />
            &nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        
                       
             <asp:Panel ID="pnlAccord" runat="server" Height="406px">
                 <div style="height:438px; width:1062px;overflow:scroll;">
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<ajaxToolkit:Accordion ID="Accordion1" runat="server" HeaderCssClass="headerCssClass" ContentCssClass="contentCssClass" HeaderSelectedCssClass="headerSelectedCss" FadeTransitions="true" TransitionDuration="500" AutoSize="None" SelectedIndex="0" Height="207px" Width="300px" style="margin-left: 281px; margin-right: 0px; margin-top: 0px;">
                <Panes>
                    <ajaxToolkit:AccordionPane ID="AccordionPane1" runat="server" >
                        <Header>03:15 Bursa-İstanbul    62 TL
                        </Header>
                        <Content><b><u></u></b>
                            <div style="text-align:center">
                            <asp:Label ID="Label3" runat="server" Text="text"></asp:Label>
                            </div>
                          
                        </Content>
                    </ajaxToolkit:AccordionPane>
                            
                    <ajaxToolkit:AccordionPane ID="AccordionPane2" runat="server">
                        <Header>07:00               Bursa-İstanbul               62 TL</Header>
                        <Content>
                            <b><u></u></b>
                           <div style="text-align:center">
                            <asp:Label ID="Label4" runat="server" Text="text"></asp:Label>
                            </div>
                        </Content>
                    </ajaxToolkit:AccordionPane>
                    <ajaxToolkit:AccordionPane ID="AccordionPane3" runat="server">
                        <Header>09:00 Bursa-İstanbul     62 TL
                        </Header>
                        <Content><b><u></u></b>
                            <div style="text-align:center">
                            <asp:Label ID="Label5" runat="server" Text="text"></asp:Label>
                            </div>
                        </Content>
                    </ajaxToolkit:AccordionPane>
                </Panes>
            </ajaxToolkit:Accordion>
                 </div>
                
                 &nbsp;</asp:Panel>
                
        </asp:Panel>
        
    </form>
</body>
</html>
