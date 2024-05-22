"use client";
import React            from 'react';
import { Button, Form } from "react-bootstrap";
import { createAction }     from "@/actions/createAction";

function CreateForm() {

    const submitForm = (formData: FormData) => {
        console.log(formData);
        createAction(formData).then(res => {
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
                <Form.Control type={"text"} name={"name"}/>
            </Form.Group>
            <Form.Group className={"mb-3"}>
                <Form.Label>Fizetés</Form.Label>
                <Form.Control type={"text"} name={"salary"}/>
            </Form.Group>
            <Form.Group className={"mb-3"}>
                <Form.Label>Kor</Form.Label>
                <Form.Control type={"text"} name={"age"}/>
            </Form.Group>
            <Form.Group className={"mb-3"}>
                <Button variant={"primary"} type={"submit"}>Mentés</Button>
            </Form.Group>
        </Form>
    );
}

export default CreateForm;
