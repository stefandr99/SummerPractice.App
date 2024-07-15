# Session 1 Exercise

## Objective
Write unit tests for the `CalculateAverage` method from the `NumberUtilities` class.

## Test framework and nuget
- **XUnit** as testing framework (project to be created)
- **FluentAssertions** nuget for unit tests assertions (**OR** default XUnit **Assert**)

## Testing Scenarios
Consider the following testing scenarios:

1. **Valid Comma-Separated Numbers**
    - Example: `"1,2,3"`.

2. **Empty String**

3. **Numbers with Some Extra Text Inside**
    - Example: `"1, two, 3"` should extract numbers and ignore non-numeric text, returning the average of valid numbers.

4. **Invalid String**
    - Example: `"one, two, three"` should throw exception

## Notes
- Do not forget to respect unit tests good practices

### Good luck! 
