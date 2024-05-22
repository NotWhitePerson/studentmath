<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class CustomerTable extends Model
{
    use HasFactory;

    public function waiter()
    {
        return $this->belongsTo(Waiter::class);
    }
}
