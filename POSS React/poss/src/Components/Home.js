import React, {useState} from 'react';
import kidsBoots from '../images/kidswaterproofboots.jpg';
import handbag from '../images/ladies-handbags.jpg';
import vest from '../images/vest.jpg';
import { connect } from 'react-redux';
import { addBasket } from '../actions/addAction';

const Home = (props) => {
    return (
        <div className="container">
            <div className="image">
                <img src={kidsBoots} alt="" />
                <h3>Kids Boot</h3>
                <h3>R150.00</h3>
                <a onClick={() => props.addBasket('kidsBoots')} className="addToCart cart1" href="#">Add To Cart</a>
            </div>
            <div className="image">
                <img src={handbag} alt="" />
                <h3>Hands Set</h3>
                <h3>R180.00</h3>
                <a onClick={() => props.addBasket('handbag')} className="addToCart cart2" href="#">Add To Cart</a>
            </div>

            <div className="image">
                <img src={vest} alt="" />
                <h3>Grey Tshirt</h3>
                <h3>R280.00</h3>
                <a onClick={() => props.addBasket('vest')} className="addToCart cart3" href="#">Add To Cart</a>
            </div>
    </div>
    )
}

export default connect(null, { addBasket })(Home);