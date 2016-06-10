# WCFCORS
To solve the issue of CORS by using Iframe + postmessage which are New HTML5 features.

Client : webapp/CORS Examples/CORS-A.aspx
CORS-A.aspx is to simulate the client to post message to WCF of JSTestDecode, which will cross origin. If we use AJAX to post to
"http://172.16.96.128/Service1.svc/postData", the cors issue will be trigger. 
So we are using iframe to post message to the page(iframe.html) which is under the same domain of our WCF, iframe.html will call the WCF by
using AJAX. So under iframe.html, the URL could be url: "../Service1.svc/postData",which wont trigger the CORS issue anymore.

WCF : JSTestDecode/Service1.svc/postData
This is to sumulate the remote API which could be called by others clients. 

        
        
        
        PS: under the webapp, there is another local WCF that would be called from local. The post method and get method have been setup, the client AJAX call has been congiged inside index.aspx, which wont trigger the CORS since it calls the WCF locally.
        
