import React, { Component } from 'react';
import { Link } from "react-router-dom";
import { Table } from 'semantic-ui-react';
import './styles/Tables.css';
import { Accordion, AccordionItem } from 'react-light-accordion';
import './styles/Catalog.css';


export class Catalog extends Component {

    static rendercourseTable(courses) {
      return (
        <Table>
            <Table.Header>
                <Table.Row>
                    <Table.HeaderCell>Courses</Table.HeaderCell>
                    <Table.HeaderCell />
                </Table.Row>
            </Table.Header>

            <Table.Body>
                {courses.map(courses => (
                      <Table.Row key={courses.courseId}>
                          <Accordion atomic={true}>
                              <AccordionItem title={courses.name}>
                                  <p>{courses.description}</p>
                              </AccordionItem>
                          </Accordion>    
                            <Table.Cell>
                              <Link
                                  to={{
                                      pathname: `catalog/${courses.courseId}`,
                                      state: {
                                          courseName: courses.name,
                                          courseDescription: courses.description
                                      }
                                  }}
                              >
                                    <button className="redButton">
                                        Upcoming Classes
                                    </button>
                              </Link>
                            </Table.Cell>
                        </Table.Row>
                    )
                )}
            </Table.Body>
        </Table>
        );
    }

    displayName = Catalog.name

    constructor(props) {
        super(props);
        this.state = { courses: [], loading: true };
    }

    componentDidMount() {
        fetch('/api/courses', { credentials: 'same-origin' })
            .then(response => response.json())
            .then(data => {
                this.setState({ courses: data, loading: false });
            });
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Catalog.rendercourseTable(this.state.courses);

        return (
            <div>
                <div>
                    <h1>Course Catalog</h1>
                    <p>
                        Keeping Safety Smart offers a variety of courses that teach valuable first responder skills. Search through
                        course listings below.
                    </p>
                </div>
                {contents}
            </div>
        );
    }
}