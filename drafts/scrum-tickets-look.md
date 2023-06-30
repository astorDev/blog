# Scrum Tickets

Ticket types:

- Epic
- User Story
- Backlog Item
- Task

For each of the ticket types, describe best practices for:

- The Ticket type title.
- The Ticket type description and attachments.

## Epic

- Good Titles: Short, Noun Based
    - By Features: 
        - If it's a new functionality, then just a name : 
            - Authorization
            - Online Payment
        - If it's a change of a functional block, then the improvements as a passive tense verb and then the noun:
            - Simplified Onboarding
            - Modernized Dashboard
    - By Version: 
        - MVP
        - Mobile App v3
        - C# 12
- Good body: 
    - The motivation behind the changes.
    - Something a user will be able to do with the feature
    - Any other relevant information

## User Story

- Good Titles: 
    - "As a ... I want to ... so that ..."??
    - A specific thing being introduced:
        - Onboarding progress indicator
        - API for creating an order
- Good description:
    - "as a ... I want to ... so that" if it's not in the title.
    - A detailed explanation of which user's actions lead to which results, including exceptional cases.
    - Design files

## Backlog Item

- Good Titles: short noun based
    - What's added/performed: 
        - POST /orders endpoint
        - GET /orders limit query parameter
        - MS SQL to PostgreSQL data migration
    - What's changed : 
        - Renaming from GET /orders-list to GET /orders
- Good description:
    - Extensively utilized Pseudo-code.
    - A detailed explanation of technical input, outputs, and side effects.
    - A limited number of non-functional requirements
    - Detailed request/response description

## Task

- Good Titles: Verb-based description of the exact action:
    - Develop `POST /orders` endpoint
    - Write docs for the `POST /orders` endpoint
    - Test the `POST /orders` endpoint
    - Deploy an API version with the `POST /orders` endpoint
- Good description: Optional low-level details
    - Links to where to find an example code.
    - Use the logging framework called X.
