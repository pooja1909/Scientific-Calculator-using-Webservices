import cgi
import math
from google.appengine.api import users
from google.appengine.ext import webapp
from google.appengine.ext.webapp.util import run_wsgi_app


class MainPage(webapp.RequestHandler):
  def get(self):
      
      self.response.out.write("""
		
			<html>
						<body>
						<center>
						<br/><br/><br/><br/><br/><br/>
							<h1 >Scientific Calculator</h1><br/><br/>
								<form action = '/Result' method = 'post'>
								<p>Operand 1&nbsp;&nbsp;<input type="number" name="op1"></input>&nbsp;&nbsp;
								Operand 2&nbsp;&nbsp;<input type="number" name="op2"></input>
								<br/><br/><br/>
								<p><button type ="submit" name="action" value="+" >&nbsp;+ &nbsp; </button>&nbsp;&nbsp;	&nbsp;						      
								<button type ="submit" name="action" value="-" >&nbsp;-&nbsp;</button>&nbsp;&nbsp;&nbsp;	
								<button type ="submit" name="action" value="*" >&nbsp;*&nbsp;</button>&nbsp;&nbsp;&nbsp;	
								<button type ="submit" name="action" value="/" >&nbsp;/&nbsp;</button>&nbsp;&nbsp;
								
								<p><button type ="submit" name="action" value="%" >&nbsp;%&nbsp;</button>&nbsp;&nbsp;								
								<button type ="submit" name="action" value="sin" >sin</button>&nbsp;&nbsp;							      
								<button type ="submit" name="action" value="cos" >cos</button>&nbsp;
								<button type ="submit" name="action" value="tan" >tan</button>&nbsp;		
					</form>
						</center>		
						</body>
				     </html>""")

class result(webapp.RequestHandler):
  def post(self):
    action = self.request.get('action')
    op1 = int(self.request.get('op1'))	

    if action =="+":
	op2 = int(self.request.get('op2'))
	op3 = op1+op2
	self.response.out.write('<html><body><center><br/><br/><br/><br/><br/>Addition is :')
	self.response.out.write(op3)
	self.response.out.write('</center></body></html>')

    elif action=="-":
	 op2 = int(self.request.get('op2'))
	 op3 = op1-op2
         self.response.out.write('<html><body><center><br/><br/><br/><br/><br/>Subtraction is :')
         self.response.out.write(op3)
         self.response.out.write('&nbsp;</center></body></html>')
    elif action=="*":
	 op2 = int(self.request.get('op2'))
	 op3 = op1*op2
         self.response.out.write('<html><body><center><br/><br/><br/><br/><br/>Multiplication is :')
         self.response.out.write(op3)
         self.response.out.write('&nbsp;</center></body></html>')
    elif action=="/":
	 op2 = int(self.request.get('op2'))
	 op3 = op1/op2
         self.response.out.write('<html><body><center><br/><br/><br/><br/><br/>Division is :')
         self.response.out.write(op3)
         self.response.out.write('&nbsp;</center></body></html>')		 
    elif action=="%":
	 op2 = int(self.request.get('op2'))
	 op3 = op1%op2
         self.response.out.write('<html><body><center><br/><br/><br/><br/><br/>Modulus is :')
         self.response.out.write(op3)
         self.response.out.write('&nbsp;</center></body></html>')
    elif action=="sin":
	 op3 = math.sin(op1)
         self.response.out.write('<html><body><center><br/><br/><br/><br/><br/>sin ')
         self.response.out.write(op1)
         self.response.out.write(' = ')		 
         self.response.out.write(op3)
         self.response.out.write('&nbsp;</center></body></html>')
    elif action=="cos":
	 op3 = math.cos(op1)
         self.response.out.write('<html><body><center><br/><br/><br/><br/><br/>cos ')
         self.response.out.write(op1)
         self.response.out.write(' = ')		 
         self.response.out.write(op3)
         self.response.out.write('&nbsp;</center></body></html>')
    elif action=="tan":
	 op3 = math.tan(op1)
         self.response.out.write('<html><body><center><br/><br/><br/><br/><br/>tan ')
         self.response.out.write(op1)
         self.response.out.write(' = ')		 
         self.response.out.write(op3)
         self.response.out.write('&nbsp;</center></body></html>')
    
application = webapp.WSGIApplication([('/', MainPage),
			    ('/Result',result)],
                            debug=True)

def main():
	run_wsgi_app(application)

if __name__ == " __main__":
	main()
