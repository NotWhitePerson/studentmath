import { Col, Row } from "react-bootstrap";
import axios        from "axios";
import List    from "@/components/List";
import { use } from "react";

async function get() {
    try {
        return (await axios.get("https://dummy.restapiexample.com/api/v1/employees")).data.data
    } catch (error) {
        return [];
    }
}

export default function Home() {
    const data = use(get())

    return (
        <Row>
            <Col>
                <List data={data} />
            </Col>
        </Row>
    );
}
