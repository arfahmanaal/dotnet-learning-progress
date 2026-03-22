# Day 21 Progress (Week 3 Assessment)

**IMPLEMENTING CRUD API**

## Tasks Completed
- **Tested `GET /api/students` - all students**
  - Returns 200 OK + JSON array of all students

  ![Day 21 GET all students](./screenshots/day21.1.png)

- **Tested `POST /api/students` - create student**
  - Returns 201 Created + new student with DB-assigned Id

  ![Day 21 POST create student](./screenshots/day21.2.png)

- **Tested `PUT /api/students/2` - update student**
  - Returns 204 No Content

  ![Day 21 PUT update student](./screenshots/day21.3.png)

- **Tested `DELETE /api/students/6` - delete student**
  - Returns 204 No Content
  - Verified in SSMS - 1 row edited and another row removed from Students table

  ![Day 21 DELETE student](./screenshots/day21.4.png)

  ![Day 21 DELETE student](./screenshots/day21.5.png)

- **Tested error scenarios - Global Exception Handling**
  - `GET /api/students/11` - 404 + ProblemDetails JSON

  ![Day 21 404 ProblemDetails](./screenshots/day21.6.png)
