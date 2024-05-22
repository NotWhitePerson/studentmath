"use client";
import React            from 'react';
import { Button, Form } from "react-bootstrap";
import { createAction }     from "@/actions/createAction";
import { updateAction } from "@/actions/updateAction";

function UpdateForm({ data }: { data: any}) {

    const submitForm = (formData: FormData) => {
        updateAction(formData, data.id).then(res => {
            if (res) {
                alert("Siker")
            } else {
                alert("Hiba")
            }
        })
    }

    return (
        <Form action={submitForm}>
            <Form.Group className={"mb-3"}>
                <Form.Label>Név</Form.Label>
                <Form.Control type={"text"} name={"name"} defaultValue={data.name} />
            </Form.Group>
            <Form.Group className={"mb-3"}>
                <Form.Label>Fizetés</Form.Label>
                <Form.Control type={"text"} name={"salary"} defaultValue={data.salary}/>
            </Form.Group>
            <Form.Group className={"mb-3"}>
                <Form.Label>Kor</Form.Label>
                <Form.Control type={"text"} name={"age"} defaultValue={data.age}/>
            </Form.Group>
            <Form.Group className={"mb-3"}>
                <Button variant={"primary"} type={"submit"}>Mentés</Button>
            </Form.Group>
        </Form>
    );
}

export default UpdateForm;
