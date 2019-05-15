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
- In the context of Domain Driven Design (DDD), what is a Bounded Context?
- Describe how the supplied code complies or violates "I".
- Describe common issues with generic repositories and some patterns to minimize them.
- Id modeling can have unintended consequences.
    * Describe pros/cons of int Ids (in all tiers of an application)
    * Describe pros/cons of Guid Ids (in all tiers of an application)

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
    