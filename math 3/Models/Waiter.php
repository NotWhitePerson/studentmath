<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Waiter extends Model
{
    use HasFactory;

    public function customerTables()
    {
        return $this->hasMany(CustomerTable::class);
    }
}
