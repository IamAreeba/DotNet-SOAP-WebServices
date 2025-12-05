


// ================================ 01: Web Service Intro ====================================
/*
    . Web Service attribute Namespace is used to uniquely identify the web service over the internet.
    . If the class name is same whni host that and other client creates class withe thwe same name its hard to find which service has to be invoked and use so we use the namespace property to uniquely identify that
    . It can be a company name or website name
    . In order to explore a method as part of webservice t the client this [WebMethod] is declared at the method level and the method should be public
    . This [WebMethod] has some overloaded functions 
    . proxy = Creating channel in client app that channel will communicate with web service
    
 */



// ================================ 02: Error Handling in Web Service ====================================
/*
    . Created the client application and consumed he calculator web service\

*/



// ================================ 03: Error Handling in Web Service ====================================
/*
    . Made a class of response and used that in calculator web service to handled the divide by 0 exception and updated the client consuming app for showing the success or error message
*/


// ================================ 04: Bindings in Web Service ====================================
/*
    . When we consume the web services bindings get invoked n web.config we have behaviour, bindings and client in system.servicemodel in web.config file
*/

// ================================ 05: WSDL in Web Service ====================================
/*
    . We know all req and res of the web service in WSDL document
*/

// ================================ 06: Proxy in Web Service ====================================
/*
    . Proxy = Creating channel in client app that channel will communicate with web service
    . Proxy classes basically makes the end points to talk to web service
*/

// ================================ 07: Session State in Web Service ====================================
/*
    . In order to allow the cookies in client we have to use the EnableSession = true attribute method in service and allowCookies = true in client web.config file
*/

// ================================ 08: TimeOut Exception in Web Service ====================================
/*
    . Threading make the execution process sleep for whatever the time range you define
    . In client web config we have used the send and receive Timeout property to make the service work in that given time if not define it will through exception
*/