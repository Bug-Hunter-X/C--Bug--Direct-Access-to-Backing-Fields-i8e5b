# C# Bug: Direct Access to Backing Fields

This repository demonstrates a common C# bug: direct access to backing fields.  While seemingly innocuous, directly accessing backing fields bypasses any logic within the property's setter and getter. This can lead to unexpected behavior, maintainability issues, and break encapsulation.

## Bug Description

The bug arises when accessing the backing field (_value) directly instead of using the property (Value).  The property might contain validation logic, side effects, or other important operations that are skipped when directly accessing the backing field. This might lead to inconsistent states and difficult-to-debug issues.

## Bug Solution

The solution is to consistently access the field using the property's getter and setter, ensuring all intended logic is executed.