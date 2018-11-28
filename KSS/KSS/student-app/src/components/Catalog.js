import React, { Component } from 'react';
import { Link } from "react-router-dom";
import { Table } from 'semantic-ui-react';
import './styles/Tables.css';
import { Accordion, AccordionItem } from 'react-light-accordion';
import './styles/Catalog.css';


export class Catalog extends Component {
    displayName = Catalog.name

    constructor(props) {
        super(props);
        this.state = {
            courses: [], displayCourses: [], loading: true, chosenCategory: '', unique: [] };
    }

    componentDidMount() {
        fetch('/api/courses', { credentials: 'same-origin' })
            .then(response => response.json())
            .then(data => {
                let model = { courses: data, displayCourses: data, loading: false, unique: ['', ...new Set(data.map(item => item.categoryName))] };
                console.log(model);
                this.setState(model);
            });
    }

    

    static rendercourseTable(courses) {
        return (
            <Table>
                <Table.Header>
                    <Table.Row>
                        <Table.HeaderCell><h2>Courses Offered</h2></Table.HeaderCell>
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
                                        See Dates
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

    // This handles the DropDown
    updateFilter(event) {
        console.log(event);
        if (event.target.value !== '') {
            let newArray = this.state.courses.filter(x => x.categoryName.indexOf(event.target.value) > -1);
            this.setState({ displayCourses: newArray, filterField: event.target.value });
        }
        else {
            this.setState({ displayCourses: this.state.courses, filterField: event.target.value });
        }
    }

// End of Dropdown

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Catalog.rendercourseTable(this.state.displayCourses);

        return (

            <div>
                <div id="catalogBanner2" alt="Catalog Classes" />

                <div className="catalogInfo">
                    <div>
                        <h2>Course Catalog</h2>
                        <p>
                        Keeping Safety Smart offers a variety of courses that teach valuable first responder skills.  Whether
                        you're interested in learning CPR and First Aid or becoming an Emergency Medical Technician,
                        our courses teach students how to make a difference! <br /><br /> View our courses below!
                        </p>
                    </div>
                </div>


                <div class="cataloggrid">
                    <div class="cataloghead">
                        <h3>Search By Category:</h3>
                    </div>

                    <div class="catalogsearch">
                        <select class="catsearch" name="category" onChange={event => this.updateFilter(event)} >
                            {this.state.unique.map((object, index) => {
                                return (
                                    <option value={object} key={object + index}>{object}</option>
                                )
                            })
                            }
                        </select>
                    </div>
                </div>
                {contents}
            </div>
        );
    }
}