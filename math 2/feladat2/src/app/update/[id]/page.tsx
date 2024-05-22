import React, { use } from 'react';
import {  Row }       from "react-bootstrap";
import CreateForm    from "@/components/CreateForm";
import axios         from "axios";
import UpdateForm     from "@/components/UpdateForm";

async function get(id: number) {
    try {
        return (await axios.get(`https://dummy.restapiexample.com/api/v1/employee/${id}`)).data.data
    } catch (error) {
        return [];
    }
}

function Page({ params } : {
    params: {
        id: number
    }
}) {

    const employee = use(get(params.id));
    console.log(employee);
    return (
        <Row>
            <UpdateForm data={employee} />
        </Row>
    );
}

export default Page;
