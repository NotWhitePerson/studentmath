<?php

namespace App\Http\Controllers;

use App\Models\CustomerTable;
use Illuminate\Http\Request;

class WaiterController extends Controller
{
    public function create(Request $request)
    {
        $customerTable = CustomerTable::create($request->all());

        return response()->json($customerTable, 201);
    }

    public function delete(CustomerTable $customertable)
    {
        $customertable->delete();

        return response()->json(null, 204);
    }
}
