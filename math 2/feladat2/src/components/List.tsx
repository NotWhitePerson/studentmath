"use client";

import React             from 'react';
import { Button, Table } from "react-bootstrap";
import Link              from "next/link";
import axios             from "axios";

function List({ data } : { data : any[]}) {

    const deleteRow = (id: number) => {
        axios.delete(`https://dummy.restapiexample.com/api/v1/delete/${id}`).then(() => {
            alert("Sikeres törlés")
        })
    }

    return (
        <Table striped>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Név</th>
                    <th>Fizetés</th>
                    <th>Kor</th>
                    <th>Műveletek</th>
                </tr>
            </thead>
            <tbody>
                {data && data.map(row => (
                    <tr key={row.id}>
                        <td>{row.id}</td>
                        <td>{row.employee_name}</td>
                        <td>{row.employee_salary}</td>
                        <td>{row.employee_age}</td>
                        <td>
                            <Button variant={"warning"}>
                                <Link href={`/update/${row.id}`}>
                                    Szerkesztés
                                </Link>
                            </Button>
                            <Button variant={"danger"} onClick={() => {
                                deleteRow(row.id)
                            }}>Törlés</Button>
                        </td>
                    </tr>
                ))}
            </tbody>
        </Table>
    );
}

export default List;
