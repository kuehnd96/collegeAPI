collegeAPI By David Kuehn
A coding exercise
Duration: ~3 hours and 15 minutes (including installation time for Sql Express)

Overall architecture and project structure inspired by recent .NET Rocks podcast episode with Steve Smith on clean architecture to promote testability, maintainability, easy to swap out a modules, separation of concerns, and readability.

Please see the InitialDesign.jpg picture in the Design folder for a look of my initial design. I drew this before any coding was done.


Noteworthy:

I had to refresh my memory on the surface area of DependencyResolver. My implementation of this would normally make use of a third-party IOC container.

I had to clean the in-state tuition data since a few colleges were missing it. I put a zero in.


Questions I would ask the Business Analyst:

1.) How should the annual cost be calculated if there is no in-state tuition?
2.) How would you like the out-of-state tuition incorporated into the annual cost calculation? (We could enhance the functionality to use some sort of indication of whether the cost should use in-state or out-of-state tuition.)
3.) Should the API be secured in some way?


If I had more time:

Unit tests would be created for the implementation of ITuitionCalculator and TuitionController. Mocks would be created for all dependencies.

An integration test would be created for TuitionController using no mocks.