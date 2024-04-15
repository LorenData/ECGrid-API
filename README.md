# Getting Started with ECGridOS™ API

[**Getting Started - Basics**](https://support.ecgrid.com/en/support/solutions/articles/6000271712-ecgridos-api-getting-started)
<br>[**Getting Started - Extended Capabilities**](https://support.ecgrid.com/en/support/solutions/articles/6000271768-ecgridos-api-getting-started-extended-capabilities)


# Quick Reference Notes 

_ECGridOS Versioning:_ The latest version of the ECGridOS API is 4.1. 

_API URL:_ https://os.ecgrid.io/v4.1/prod/ECGridOS.asmx

[ECGridOS API Call Library](https://github.com/LorenData/ECGrid-API/wiki/API-Calls)

[ECGridOS API Wiki Page](https://github.com/LorenData/ECGrid-API/wiki/ECGridOS-Wiki)

_ECGridOS Web Services:_ Given the confidential nature of electronic commerce, ECGridOS can only be accessed securely over HTTPS. 

_ECGridOS Support:_ ECGrid Support can be reached at support@ecgrid.com.  



# Introduction to ECGridOS™ 

The ECGridOS platform was developed by Loren Data Corp., an established provider of supply chain messaging infrastructure and services since 1996. ECGridOS™ is an Operating System as a Service (OSaaS), that manages the ECGrid® Supply Chain Integration Network, transporting transactions, messages, and reports between businesses around the world. ECGridOS hosts a robust set of discrete platform processes such as Web Service APIs, enabling developers to integrate supply chain communications capabilities into mission-critical applications, systems, and workflows. 

ECGridOS is specifically designed for quick, secure, and accurate electronic business documents exchange, such as purchase orders, invoices, and shipping notices, between hundreds of thousands of trading partners around the globe. ECGrid supports all file formats including legacy Electronic Data Interchange (EDI) standards such as X12 and EDIFACT as well as all modern formats including XML, JSON and all user-defined data formats. 

Cloud applications frequently publish sets of web service APIs to extend access into system data, allowing users and developers basic functions to integrate externally. ECGridOS takes web services to the next level as a 100% API-based web service-based operating system. ECGridOS delivers all the capabilities required to internally operate and externally integrate a global supply chain communications network.   

ECGridOS publishes an extensive library of APIs which delivers full command, control, and communication functionality over operations, integrations, and implementations. Like a traditional operating system, ECGridOS is a foundational application with over 200 fine grain API’s, covering all aspects of EDI network configuration and communications. ECGridOS delivers all core ECGrid internal processes and provides the platform for all external communication channels and user portal access. External developers will find the complete set of tools to support the full-lifecycle of an organization’s implementation – Onboarding, Management and Offboarding. ECGridOS provides a set of essential services and functions that enable the effective and efficient use of the ECGrid network directly from enterprise applications, such as an ERP or WMS system, or integration into cloud platforms that support supply chain data exchange.  

Strategically, ECGridOS is about increased control and flexibility using “fine grain” (SOAP) APIs for a more interactive programming model than found in “coarse grain” (REST) API integration projects. The ECGrid approach puts partners, customers, and SaaS platform teams in full control of their implementation. 

 

# Benefits of a Fine-Grain API Approach

A fine-grain API approach, where the API exposes a larger number of methods or functions that perform smaller, more specific tasks, can offer several benefits depending on the context and requirements of a particular software development project. Some advantages of using a fine-grain API include: 

1. **Granular Control:** Fine-Tuned Operations: Developers have more control over individual components or operations. This level of granularity allows them to fine-tune interactions with the system, performing specific actions as needed. 

2. **Flexibility and Customization:** Tailored Solutions: Fine-grain APIs enable developers and ISVs to create more customized and tailored solutions for their customers using ECGridOS. They can choose specific methods relevant to their use case and build solutions with precisely the desired functionality. 

3. **Efficiency in Resource Utilization:** Developers can optimize resource usage by invoking only the necessary fine-grain operations. This can lead to more efficient utilization of system resources, such as network bandwidth, memory, and processing power. 

4. **Scalability:** Developers can scale different components independently, making it easier to adapt to changing requirements and handle increased loads in specific areas of the application. 

5. **Modularity:** Fine-grain APIs promote a modular development approach. Each fine-grain method can represent a module or a specific feature, making it easier to develop, test, and maintain modular code. 

6. **Enhanced Debugging and Testing:** Fine-grain APIs allow for more granular testing of individual components, making it easier to identify and address issues. Debugging can be more focused on specific functionalities, simplifying the troubleshooting process. 

7. **Diverse Use Cases:** ECGrid’s fine-grain APIs support diverse use cases. Developers can leverage the flexibility of the API to address a wide range of requirements without being constrained by a predefined set of higher-level coarse-grain APIs. 

With ECGridOS you can start with a single use case and extend to more advanced capabilities over time. Engineers and ISVs are not limited in their options while automating their B2B data exchange. 

Key Capabilities supported by the ECGridOS library to facilitate your B2B data exchange requirements include: 

1. **Account provisioning:** ECGridOS allows for full control of account provisioning and management via APIs right from your organization’s infrastructure and systems consistent with your organizational controls and workflows.   

	- **User/Customer Onboarding:** 

		- _Account and Mailbox Creation:_ When a new employee joins an organization, account provisioning involves creating user accounts for them in relevant systems. This includes assigning a unique username, password, and any necessary identification details with role-based access controls. 

		- _Role-Based Access:_ Account provisioning often aligns with role-based access principles to ensure users have access only to the resources necessary for their job roles and implementation requirements. 

	- **Access Permissions:** Based on the user's role and responsibilities, account provisioning establishes the appropriate access permissions to IT resources. This may include access to email, file repositories, applications, and other services. 

	- **Updates to User Attributes:** Changes to user attributes, such as contact information or job title, may also be part of the account provisioning process to keep user records accurate. 

	- **User/Customer Offboarding:** When an employee leaves the organization or changes roles, account provisioning includes deactivating or disabling their account to prevent unauthorized access. This is a critical step in maintaining security and compliance. 

2. **Connectivity:** Use the APIs to create and manage communications to and from your network and external environments (trading partner, service provider, VAN, etc.). ECGridOS allows you to connect to your partners regardless of protocol or the network they use. 

3. **Transaction Management and Data Exchange:**  The platform allows users to send and receive data directly from their trading partners and to track the status of EDI transactions/files, providing visibility into the status of messages as they move through the communication process. 

4. **Message Routing:** ECGridOS helps in routing EDI messages between trading partners, ensuring that the right information reaches the intended recipient. The platform also provides rich content support and content routing by supporting various EDI standards and protocols, ensuring compatibility with different trading partners and industry requirements. ECGridOS also allows the configuration of managed file transfer (MFT) for non-standards-based data. 

5. **Trading Partner Management:** ECGridOS facilitates the management of trading partner relationships, including the onboarding of new partners and the configuration of EDI communication settings. 

6. **Alerts and Notifications:** Users can set up alerts and notifications to be informed of important events, such as the receipt of new messages or the status changes of transactions. 

7. **Error Handling/Management:** The OS monitors the system for errors and faults, providing error handling mechanisms to prevent catastrophic failures. It may also log errors and generate reports for diagnostics and troubleshooting. 

8. **Security:** Secure data exchange is essential in EDI and ECGridOS includes mechanisms for secure data transmission, authentication, and authorization to protect sensitive business information. 
