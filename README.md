# icehammer-unity
Unity3D plugin for IceHammer

[API docs](https://documenter.getpostman.com/view/4221390/RWMFrnaV)

[Google Spread Sheet for test project](https://docs.google.com/spreadsheets/d/1vj9ZiUeByetKBnyMHDKv9J4pYcwDPTyAz5hRZHB_y5Y)


## Overview

Each entity in IceHammer has an ID. It's a random 24 byte array encoded with URL safe Base64. Example: **G_271bd-mg1ZPrna0XxAS0aT56BxS0tA**.

The starting point is a **Project**. Each project has an ID. This ID can be found on IceHammer web page. Or in the URL: the part of the link between **...project/** and the next slash **/...**  (ex: https://app.icehammer.org/project/ **G_271bd-mg1ZPrna0XxAS0aT56BxS0tA** /...). This ID is to be manually copied into a project and to be commited to CVS.

A **Project** consists of several tables called **Data Sheet**. Each **Data Sheet** is connected to a Google Spread Sheet. In order to be able to read the data from Google Data Sheet it requires:
  1. header row number (as it appears in Google Spread Sheet starting with 1)
  2. Sheet title (those tabs on the bottom of Google Spread Sheet editor)
Having a project ID one can always fetch current list of **Data Sheets** via API.

Each **Data Scheet** has serveral **Schemas**. One can always fetch the latest Schema for a Data Sheet via API. The Schema is a list of columns and their types. The idea behind a Schema is to contain all necessary information about Data Sheet which is required to generate data loading code. After this is done one can always fetch the new data for the given schema via API. An one can do it **perfectly safe even after game release**. That is where all server-side validation is done.
The Schema ID should be commited to VCS. This makes a connection between code and data. Techically generated data loading code can be excluded from VCS simply because having Schema ID allows you to regenerate exactly the same data loading code.
