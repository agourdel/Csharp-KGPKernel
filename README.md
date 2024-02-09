# KGPKernel
C# Virgin "ready-to-development-scale" Kernel for organizations following the Ker-G Pattern 

---

## Kernel's boundaries 

- The KGP Kernel's goal is to contain all of the business code of an application.
- The KGP Kernel is agnostic of the context of use.
- The Contextual Application (Web App, CLI, Desktop application, etc..) that uses the Kernel has to provide it with access to configuration attributes, external providers and the data persistence layer by implementing the interfaces *IConfigsManager*, *IProvidersManager* and *IRepositoriesManager*.


--- 

## Layers' boundaries

- Roles, Domains and Services are the layers of the kernel.
- Roles, Domains and Services are each designed to be respectively developed in isolation from other objects of the same layer.

- Roles are designed to be easily developped by different developpers in the same Kernel Repo.
- Roles can make calls to Domains and Services.

- Domains are designed to be developped outside the Kernel Repo (In order to be reused by different kernels) as well as inside the Kernel Repo.
- Domains are Roles-agnostic and can make calls to Services.
- Domains may have private Subdomains.

- Services are Roles-agnostic and domains-agnostics.
- Services are encapsulation for external service providers, external domains (Micro-services) and "domains" whose purpose is to serve other domains.

## Tips for getting started

From Scratch :
- Copy/Past */Domains/_FooDomain* and start to develop domains.
- Copy/Past */Services/_ExampleService* each time a domain need one.

*more to come...*

---

### Contact

Do you want to know more about the KGP Kernel and the Ker-G Pattern?
Please feel free to ping me at [@AlexandreGrdl](https://twitter.com/AlexandreGrdl "@AlexandreGrdl")