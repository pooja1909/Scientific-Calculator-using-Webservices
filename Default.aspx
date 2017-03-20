<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp; OPERAND 1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    OPERAND 2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    RESULT<br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged" 
        Width="122px" Height="43px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Height="45px" 
        ontextchanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" Height="43px" 
        ontextchanged="TextBox3_TextChanged"></asp:TextBox>
    <br />
&nbsp;&nbsp;
    <br />
    <asp:Button ID="Button1" runat="server" Text="backspace" Width="107px" 
        onclick="Button1_Click1" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="sin" onclick="Button2_Click1" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Text="cos" onclick="Button3_Click1" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="tan" />
&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button5" runat="server" Text="sin-1" onclick="Button5_Click" 
        Width="35px" />
&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button6" runat="server" onclick="Button6_Click" Text="cos-1" 
        Width="37px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button7" runat="server" onclick="Button7_Click" Text="tan-1" 
        Width="34px" />
    <br />
    <br />
    <asp:Button ID="Button9" runat="server" onclick="Button9_Click" Text="pi" 
        style="width: 24px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:Button ID="Button10" runat="server" onclick="Button10_Click" Text="7" />
&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button11" runat="server" Text="8" onclick="Button11_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button12" runat="server" Text="9" onclick="Button12_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button13" runat="server" Text="/" onclick="Button13_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button14" runat="server" Text="x!" onclick="Button14_Click1" 
        Width="24px" />
&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button15" runat="server" Text="nPr" Width="32px" 
        onclick="Button15_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button16" runat="server" Text="nCr" Width="35px" 
        onclick="Button16_Click" />
&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Button ID="Button17" runat="server" Text="OFF" onclick="Button17_Click" 
        style="width: 40px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button18" runat="server" Text="4" onclick="Button18_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button19" runat="server" Text="5" onclick="Button19_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button20" runat="server" Text="6" onclick="Button20_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button21" runat="server" Text="*" onclick="Button21_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button22" runat="server" Text="X^2" onclick="Button22_Click1" 
        Width="33px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button23" runat="server" Text="X^3" onclick="Button23_Click1" 
        Width="34px" />
&nbsp;
&nbsp;
    <asp:Button ID="Button24" runat="server" Text="X^Y" onclick="Button24_Click" 
        Width="34px" />
&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Button ID="Button25" runat="server" onclick="Button25_Click" Text="CE" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button26" runat="server" Text="1" onclick="Button26_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button27" runat="server" Text="2" onclick="Button27_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button28" runat="server" Text="3" onclick="Button28_Click" 
        style="width: 21px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button29" runat="server" Text="-" onclick="Button29_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button30" runat="server" onclick="Button30_Click" Text="+/-" 
        Width="27px" />
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button31" runat="server" Text="%" onclick="Button31_Click" 
        Width="28px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button32" runat="server" Text="1/x" onclick="Button32_Click" 
        Width="32px" />
&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Button ID="Button33" runat="server" Text="AC" onclick="Button33_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button34" runat="server" Text="0" onclick="Button34_Click" />
&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button35" runat="server" Text="." onclick="Button35_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button36" runat="server" Text="=" onclick="Button36_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button37" runat="server" Text="+" onclick="Button37_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button38" runat="server" Text="SQRT" Width="37px" 
        onclick="Button38_Click1" style="margin-left: 0px" />
    &nbsp;&nbsp;<asp:Button ID="Button39" runat="server" Text="ln x" style="margin-left: 10px" 
        Width="35px" onclick="Button39_Click" />
&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button8" runat="server" onclick="Button8_Click" Text="log x" 
        Width="36px" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>