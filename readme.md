# Kata 005

## Summary
 Covers the "I" and "D" in SOLID, domain driven design (DDD), ID modelling, Maybe<> monad

## Pre Reading
- [All articles here](https://martinfowler.com/tags/domain%20driven%20design.html)
- [Maybe<>](https://enterprisecraftsmanship.com/2015/03/13/functional-c-non-nullable-reference-types/)
- [I](https://www.dotnetcurry.com/software-gardening/1257/interface-segregation-principle-isp-solid-principle)
- [D](https://www.dotnetcurry.com/software-gardening/1284/dependency-injection-solid-principles)

## Discussion
- Research the "I" in SOLID. 
    * Describe what this means in terms of software development
    Interface Segregation Principle - A Client should not be forced to implement an interface that it doesn’t use

- In the context of Domain Driven Design (DDD), what is a Bounded Context?
Bounded Context is a central pattern in Domain-Driven Design. It is the focus of DDD's strategic design section which is all about dealing with large models and teams. DDD deals with large models by dividing them into different Bounded Contexts and being explicit about their interrelationships.
https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/microservice-ddd-cqrs-patterns/ddd-oriented-microservice
https://martinfowler.com/bliki/BoundedContext.html

- Describe how the supplied code complies or violates "I".
A Client should not be forced to implement an interface that it doesn’t use.

- Describe common issues with generic repositories and some patterns to minimize them.
A generic repository is often used with the entity framework to speed up the process of creating a data layer. In most cases this is a generalization too far and it can be a trap for lazy developers.
https://www.ben-morris.com/why-the-generic-repository-is-just-a-lazy-anti-pattern/

- Id modeling can have unintended consequences.
    * Describe pros/cons of int Ids (in all tiers of an application)
        You want easily-understood IDs.
        You want your URLs to be "hackable" by your end-users.
        You are concerned about performance (in very large applications).
    * Describe pros/cons of Guid Ids (in all tiers of an application)
        You want the data to be uniquely-identified, no matter where it came from.
        You need to be able to combine data from difference sources with little-to-no chance of duplicate GUIDs.
        You don't want or don't care about the users needing to remember an ID themselves.

    https://exceptionnotfound.net/integers-vs-guids-the-great-primary-key-debate/

## Thought Exercise
Consider 
``` cs
var user = _repository.GetUserById(5);
```
If user is null, can you determine any of the following?
- no user with that id exists
- the caller does not have access to the user with that id
- some connected issue occured, such as a database being down, and an exception was handled lower in the stack
     
Now consider
``` cs
Maybe<User, UserError> = _repository.GetUserById(5);
```
If the result has no value, how much more information is provided?

One caveat is that Maybe<> is an implementaion detail, and should not be surfaced past the layer of code that understands how to handle TError, otherwise it would result in an anemic domain model. Discuss various boundaries for Maybe<>

## Code Exercise
- Refactor the supplied code to be in compliance with "I" and "D" design principles.
    * Continue to refactor the code to use DI through [SimpleInjector](https://simpleinjector.org/index.html) and the Maybe<> monad

- Review the article on the Maybe monad ()
    * While not a true monad, what problem is it trying to solve?
    * How can it be applied to fix an issue with querying by Id in the current code?
    * Implement the struct (removing the Contract and AllowNull code) to elevate meaning to the repostory results.
    * When do you think Maybe<> is applicable? When is it not applicable?

    https://mikhail.io/2018/07/monads-explained-in-csharp-again/
    
    The ?? operator is called the null-coalescing operator. It returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand.

    https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator